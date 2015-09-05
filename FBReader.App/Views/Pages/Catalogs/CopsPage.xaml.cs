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
using FBReader.AppServices.ViewModels.Pages.Catalogs;
using FBReader.DataModel.Model;
using Telerik.Windows.Controls;

namespace FBReader.App.Views.Pages.Catalogs
{
    public partial class CopsPage
    {
        public CopsPageViewModel ViewModel
        {
            get { return (CopsPageViewModel) DataContext; }
        }

        public CopsPage()
        {
            InitializeComponent();
        }

        private void NavigateToSearch(object sender, EventArgs e)
        {
            ViewModel.NavigateToSearch();
        }

        private void AppBarLogoutMenuItemClick(object sender, EventArgs e)
        {
            ViewModel.Logout();
        }

        private void AppBarRefreshMenuItemClick(object sender, EventArgs e)
        {
            ViewModel.Update();
        }

        private void ItemsControl_OnItemTap(object sender, ListBoxItemTapEventArgs e)
        {
            ViewModel.NavigateToItem((CatalogItemModel)e.Item.DataContext);
        }

        private void ItemsControl_OnSelectionChanging(object sender, SelectionChangingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}