﻿/*
 * Author: CactusSoft (http://cactussoft.biz/), 2013
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA
 * 02110-1301, USA.
 */

using System;
using System.Globalization;
using System.Windows.Data;

namespace FBReader.App.Converters
{
    public class BrightnessToOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var brightness = System.Convert.ToInt32(value);
            return 1 - brightness / 100f;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var opacity = System.Convert.ToDouble(value);
            return (int)Math.Floor((1 - opacity) * 100);
        }
    }
}
