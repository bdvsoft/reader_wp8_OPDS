using System.Threading.Tasks;
using FBReader.Common;
using FBReader.DataModel.Model;

namespace FBReader.AppServices
{
    public class DataBaseInitializer
    {
        public async Task ExecuteAsync()
        {
            using (var db = BookDataContext.Connect())
            {
                AddDefaultCatalogs(db);
            }
        }

        private void AddDefaultCatalogs(BookDataContext dataContext)
        {
            /*
            var catalog = new CatalogModel
            {
                Url = "http://data.fbreader.org/catalogs/litres2/index.php5",
                Title = "FBReader_Litres",
                Description = "description",
                IconLocalPath = "/Resources/Icons/litres_icon.jpg",
                SearchUrl = "http://data.fbreader.org/catalogs/litres2/search.php5?query={0}",
                Type = CatalogType.Litres
            };
            dataContext.Catalogs.InsertOnSubmit(catalog);
            /*/
            var catalog = new CatalogModel
            {
                Url = "http://194.58.90.83:8081",
                Title ="Библиотеке",
                Description = "description",
                IconLocalPath = "/Resources/Icons/cops_icon.jpg",
                SearchUrl = "http://194.58.90.83:8081/?searchType=books&searchTerm={0}",
                OpenSearchDescriptionUrl = "http://194.58.90.83:8081/web?id=07",

                Type = CatalogType.OPDS
            };
            dataContext.Catalogs.InsertOnSubmit(catalog);
            //*/

            dataContext.SubmitChanges();
        }
    }
}
