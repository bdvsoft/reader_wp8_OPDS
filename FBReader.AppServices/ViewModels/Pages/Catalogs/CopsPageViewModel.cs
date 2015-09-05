using Caliburn.Micro;
using FBReader.AppServices.CatalogReaders.Authorization;
using FBReader.AppServices.CatalogReaders.Readers;
using FBReader.AppServices.Controller;
using FBReader.AppServices.Services;
using FBReader.DataModel.Model;
using FBReader.DataModel.Repositories;

namespace FBReader.AppServices.ViewModels.Pages.Catalogs
{
    public class CopsPageViewModel : CatalogPageViewModel
    {
        private bool _isItemsState;

        public CopsPageViewModel(
            ICatalogReaderFactory catalogReaderFactory,
            ICatalogRepository catalogRepository,
            INotificationsService notificationsService,
            INavigationService navigationService,
            CatalogController catalogController,
            ICatalogAuthorizationFactory catalogAuthorizationFactory)
            : base(catalogReaderFactory,
                catalogRepository,
                notificationsService,
                navigationService,
                catalogController, catalogAuthorizationFactory)
        {
        }

        public override int CatalogId
        {
            get { return 2; }
        }

        public override void GoBack()
        {
            base.GoBack();
            IsItemsState = false;
        }

        public bool IsItemsState
        {
            get { return _isItemsState; }
            set
            {
                _isItemsState = value;
                NotifyOfPropertyChange(() => IsItemsState);
            }
        }

        public void NavigateToLanguages()
        {
            var treeReader = CatalogReader as OpdsCatalogReader;
            if (treeReader == null)
                return;

            IsItemsState = true;
            FolderItems = null;
            treeReader.GoTo(new CatalogItemModel { OpdsUrl = "http://194.58.90.83:8081/?id=04" });
            LoadItems();
        }

        public void NavigateToAuthors()
        {
            var treeReader = CatalogReader as OpdsCatalogReader;
            if (treeReader == null)
                return;

            IsItemsState = true;
            FolderItems = null;
            treeReader.GoTo(new CatalogItemModel { OpdsUrl = "http://194.58.90.83:8081/?id=02" });
            LoadItems();
        }

        public void NavigateToTags()
        {
            var treeReader = CatalogReader as OpdsCatalogReader;
            if (treeReader == null)
                return;

            IsItemsState = true;
            FolderItems = null;
            treeReader.GoTo(new CatalogItemModel { OpdsUrl = "http://194.58.90.83:8081/?id=01" });
            LoadItems();
        }
        
        public void NavigateToNames()
        {
            var treeReader = CatalogReader as OpdsCatalogReader;
            if (treeReader == null)
                return;

            IsItemsState = true;
            FolderItems = null;
            treeReader.GoTo(new CatalogItemModel { OpdsUrl = "http://194.58.90.83:8081/?id=06" });
            LoadItems();
        }
    }
}