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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Caliburn.Micro;
using FBReader.Localization;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;


namespace FBReader.App.Views.Pages.Settings
{
    public partial class AboutView : UserControl
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailcomposer = new EmailComposeTask();
            emailcomposer.To = "bdv17@inbox.ru";
            emailcomposer.Subject = "Приложение читай";
            emailcomposer.Body = "";
            emailcomposer.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WebBrowserTask web = new WebBrowserTask();
            web.Uri = new Uri("https://www.facebook.com/BashckatowDmitry");
            web.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WebBrowserTask web = new WebBrowserTask();
            web.Uri = new Uri("https://vk.com/bdv17");
            web.Show(); 
        }

        private void RichTextBox_ContentChanged(object sender, ContentChangedEventArgs e)
        {

        }
    }
}
