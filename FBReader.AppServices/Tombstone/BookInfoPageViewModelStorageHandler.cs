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

using Caliburn.Micro;
using FBReader.AppServices.ViewModels.Pages;

namespace FBReader.AppServices.Tombstone
{
    class BookInfoPageViewModelStorageHandler : StorageHandler<BookInfoPageViewModel>
    {
        public override void Configure()
        {
            Property(vm => vm.ImageUrl).InPhoneState();
            Property(vm => vm.ApplicationBarIndex).InPhoneState();
            Property(vm => vm.Title).InPhoneState();
            Property(vm => vm.Type).InPhoneState();
            Property(vm => vm.Author).InPhoneState();
            Property(vm => vm.Description).InPhoneState();
            Property(vm => vm.BookId).InPhoneState();
            Property(vm => vm.IsBookFree).InPhoneState();
            Property(vm => vm.Language).InPhoneState();
            Property(vm => vm.CatalogBookItemModel).InPhoneState();
            Property(vm => vm.CatalogId).InPhoneState();
            Property(vm => vm.CanDownloadTrial).InPhoneState();
            Property(vm => vm.StartDownload).InPhoneState();
        }
    }
}