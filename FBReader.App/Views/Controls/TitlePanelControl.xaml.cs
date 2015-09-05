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
using System.Windows;
using System.Windows.Controls;

namespace FBReader.App.Views.Controls
{
    public partial class TitlePanelControl : UserControl
    {
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof (string), typeof (TitlePanelControl), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty SubtitleProperty =
            DependencyProperty.Register("Subtitle", typeof (string), typeof (TitlePanelControl), new PropertyMetadata(default(string), PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            var @this = (TitlePanelControl) dependencyObject;
            string newSubtitle = e.NewValue.ToString();

            @this.SubtitleText.Visibility = string.IsNullOrWhiteSpace(newSubtitle) ? Visibility.Collapsed : Visibility.Visible;
        }

        public string Subtitle
        {
            get { return (string) GetValue(SubtitleProperty); }
            set { SetValue(SubtitleProperty, value); }
        }

        public string Title
        {
            get { return (string) GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public TitlePanelControl()
        {
            InitializeComponent();
        }
    }
}
