/*
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
using FBReader.Settings;

namespace FBReader.App.Controls.Manipulations
{
    public class ManipulatorFactory
    {
        private readonly ThreePagePanel _panel;

        public ManipulatorFactory(ThreePagePanel panel)
        {
            _panel = panel;
        }

        public PageManipulatorBase CreateManipulator(FlippingStyle type, FlippingMode mode)
        {
            switch (type)
            {
                case FlippingStyle.None:
                    return new StaticDragPageManipulation(_panel, mode);

                case FlippingStyle.Overlap:
                    return new OverlappingDragPageManipulation(_panel, mode);

                case FlippingStyle.Shift:
                    return new ContinuousDragPageManipulation(_panel, mode);

                default:
                    throw new NotSupportedException();
            }
        }
    }
}