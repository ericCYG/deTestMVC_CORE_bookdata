using deTestMVC_CORE_bookdata.Models;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace deTestMVC_CORE_bookdata.ViewModels.BookData
{
    public class BookDataCollection
    {
        public string ClassIdSort { get; set; } = "";
        public string NameSort { get; set; } = "";
        public string BoughtDateSort { get; set; } = "";
        public string StatusSort { get; set; } = "";
        public string KeeperSort { get; set; } = "";
      
        public CBookDatumViewModel bdViewModel{get ;set;}

        public List<CBookDatumViewModel> cBookDatumViewModels { get ;set;}
        public List<SelectListItem> dropListBookClassID { get; set; } 

        public List<SelectListItem> dropListBookStatusID { get; set; }
        public List<SelectListItem> dropDownListKepper { get; set; }

    }
}
