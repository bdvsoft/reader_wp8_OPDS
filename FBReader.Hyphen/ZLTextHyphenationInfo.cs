namespace FBReader.Hyphen
{
    public sealed class ZLTextHyphenationInfo
    {
        public bool[] Mask { get; private set; }

	    public ZLTextHyphenationInfo(int length) {
            Mask = new bool[length - 1];
	    }

	    public bool IsHyphenationPossible(int position) {
            return (position < Mask.Length && Mask[position]);
	    }
    }
}
