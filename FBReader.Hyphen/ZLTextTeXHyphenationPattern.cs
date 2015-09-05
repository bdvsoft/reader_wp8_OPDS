using System;
using System.Linq;
using System.Text;

namespace FBReader.Hyphen
{
    public sealed class ZLTextTeXHyphenationPattern : IEquatable<ZLTextTeXHyphenationPattern>
    {
        public ZLTextTeXHyphenationPattern(char[] pattern, int offset, int length, bool useValues)
        {
            if (useValues)
            {
                int patternLength = pattern.Count(s => !char.IsDigit(s));

                var symbols = new char[patternLength];
                var values = new byte[patternLength + 1];

                for (int i = 0, k = 0; i < length; ++i)
                {
                    char sym = pattern[offset + i];
                    if (char.IsDigit(sym))
                    {
                        values[k] = (byte) (sym - '0');
                    }
                    else
                    {
                        symbols[k] = sym;
                        ++k;
                    }
                }

                Length = patternLength;
                Symbols = symbols;
                Values = values;
            }
            else
            {
                var symbols = new char[length];
                Array.Copy(pattern, offset, symbols, 0, length);
                Length = length;
                Symbols = symbols;
                Values = null;
            }
        }

        public int Length { get; set; }
        public char[] Symbols { get; private set; }
        public byte[] Values { get; private set; }

        #region IEquatable<ZLTextTeXHyphenationPattern> Members

        public bool Equals(ZLTextTeXHyphenationPattern pattern)
        {
            int len = Length;
            if (len != pattern.Length)
            {
                return false;
            }

            char[] a1 = Symbols;
            char[] a2 = pattern.Symbols;

            while (len-- != 0)
            {
                if (a1[len] != a2[len]) 
                    return false;
            }

            return true;
        }

        public override bool Equals(Object o)
        {
            if (ReferenceEquals(null, o)) return false;
            if (ReferenceEquals(this, o)) return true;
            return o is ZLTextTeXHyphenationPattern && Equals((ZLTextTeXHyphenationPattern) o);
        }

        #endregion

        public void Update(char[] pattern, int offset, int length)
        {
            // We assert
            // 		1. this pattern doesn't use values
            // 		length <= original pattern length
            Array.Copy(pattern, offset, Symbols, 0, length);
            Length = length;
        }

        public void Apply(byte[] mask, int position)
        {
            int patternLength = Length;
            byte[] values = Values;
            for (int i = 0, j = position; i <= patternLength; ++i, ++j)
            {
                byte val = values[i];
                if (mask[j] < val)
                {
                    mask[j] = val;
                }
            }
        }

        public override int GetHashCode()
        {
			char[] symbols = Symbols;
			int hash = 0;

            for (int i = Length - 1; i >= 0; --i)
            {
                hash *= 31;
                hash += symbols[i];
            }

		    return hash;
        }

        public override String ToString()
        {
            var buffer = new StringBuilder();
            for (int i = 0; i < Length; ++i)
            {
                if (Values != null)
                {
                    buffer.Append((int) Values[i]);
                }
                buffer.Append(Symbols[i]);
            }
            if (Values != null)
            {
                buffer.Append((int) Values[Length]);
            }
            return buffer.ToString();
        }
    }
}