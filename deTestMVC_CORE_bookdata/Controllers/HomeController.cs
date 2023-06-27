using deTestMVC_CORE_bookdata.Models;
using deTestMVC_CORE_bookdata.ViewModels.BookData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;

namespace deTestMVC_CORE_bookdata.Controllers
{
    public class HomeController : Controller
    {

        private readonly GsswebContext _context;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger, GsswebContext context)
        {
            _logger = logger;
            _context = context;
        }


        public BookDataCollection GetDropDownList(ref BookDataCollection bdc)
        {
            bdc.bdViewModel = new CBookDatumViewModel();
            bdc.dropListBookClassID = _context.BookClasses.Select(_ =>
                                 new SelectListItem
                                 {
                                     Value = _.BookClassId,
                                     Text = _.BookClassId + "-" + _.BookClassName
                                 }).ToList();

            if (TempData["bookClassID"] != null)
            {
                bdc.bdViewModel.BookClassId = TempData["bookClassID"] as string;
            }

            //foreach (var option in bdc.dropListBookClassID)
            //{
            //    if (TempData["bookClassID"] != null)
            //    {
            //        option.Selected = option.Value == TempData["bookClassID"].ToString();
            //    }
            //}

            bdc.dropDownListKepper = _context.MemberMs.Select(_ =>
                new SelectListItem()
                {
                    Value = _.UserId,
                    Text = _.UserEname
                }
            ).ToList();

            //foreach (var option in bdc.dropDownListKepper)
            //{
            //    if (TempData["keeper"] != null)
            //    {
            //        option.Selected = option.Value == TempData["keeper"].ToString();
            //    }
            //}
            if (TempData["keeper"] != null)
            {
                bdc.bdViewModel.BookKeeper = TempData["keeper"] as string;
            }
            bdc.dropListBookStatusID = _context.BookCodes
              .Where(_ => _.CodeType == "BOOK_STATUS")
              .Select(_ =>
                                new SelectListItem
                                {
                                    Value = _.CodeId,
                                    Text = _.CodeId + "-" + _.CodeName
                                }).ToList();

            //foreach (var option in bdc.dropListBookStatusID)
            //{
            //    if (TempData["keepStatus"] != null)
            //    {
            //        option.Selected = option.Value == TempData["keepStatus"].ToString();
            //    }
            //}
            if (TempData["keepStatus"] != null)
            {
                bdc.bdViewModel.BookStatus = TempData["keepStatus"] as string;
            }
            return bdc;
        }

        [HttpGet]
        public IActionResult Create()
        {

            BookDataCollection bookDataCollection = new BookDataCollection();

            GetDropDownList(ref bookDataCollection);


            return View(bookDataCollection);
        }

        [HttpPost]
        public IActionResult Create(BookDataCollection bkc)
        {

            _context.Add(bkc.bdViewModel.bookDatum);
            //return Redirect("~/home/index");
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");

        }

        public IActionResult Index(string sortOrder)
        {
            BookDataCollection bookDataCollection = new BookDataCollection();
            //下拉選單


            GetDropDownList(ref bookDataCollection);



            //下面準備view的list
            List<BookDatum> bb = _context.BookData
                .Join(_context.BookClasses, a => a.BookClassId, b => b.BookClassId, (a, b) => new { a, b })
                .Join(_context.MemberMs, ab => ab.a.BookKeeper, c => c.UserId, (ab, c) => new { ab, c })
                .Join(_context.BookCodes, _ => _.ab.a.BookStatus, d => d.CodeId, (abc, d) => new { abc, d })
                .Select(all => new BookDatum
                {
                    BookClassId = all.abc.ab.b.BookClassName,
                    BookName = all.abc.ab.a.BookName,
                    BookBoughtDate = all.abc.ab.a.BookBoughtDate,
                    BookStatus = all.d.CodeName,
                    BookKeeper = all.abc.c.UserEname
                })
                .ToList();



            List<BookDatum> books = _context.BookData.ToList();    //測試前使用

            books = bb;

            List<CBookDatumViewModel> bookData = new List<CBookDatumViewModel>();

            foreach (BookDatum bookDatum in books)
            {
                bookData.Add(new CBookDatumViewModel() { bookDatum = bookDatum });
            }

            //BookDataCollection bookDataCollection = new BookDataCollection();
            //bookDataCollection.cBookDatumViewModels = bookData;





            bookDataCollection.ClassIdSort = sortOrder == "classID_asc" ? "classID_desc" : "classID_asc";
            bookDataCollection.NameSort = sortOrder == "Name_asc" ? "Name_desc" : "Name_asc";
            bookDataCollection.BoughtDateSort = sortOrder == "BoughtDate_asc" ? "BoughtDate_desc" : "BoughtDate_asc";
            bookDataCollection.StatusSort = sortOrder == "Status_asc" ? "Status_desc" : "Status_asc";
            bookDataCollection.KeeperSort = sortOrder == "Keeper_asc" ? "Keeper_desc" : "Keeper_asc";

            switch (sortOrder)
            {
                case "classID_desc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderByDescending(_ => _.BookClassId).ToList();
                    break;
                case "classID_asc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderBy(_ => _.BookClassId).ToList();
                    break;
                case "Name_desc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderByDescending(_ => _.BookName).ToList();
                    break;
                case "Name_asc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderBy(_ => _.BookName).ToList();
                    break;
                case "BoughtDate_desc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderByDescending(_ => _.BookBoughtDate).ToList();
                    break;
                case "BoughtDate_asc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderBy(_ => _.BookBoughtDate).ToList();
                    break;
                case "Status_desc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderByDescending(_ => _.BookStatus).ToList();
                    break;
                case "Status_asc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderBy(_ => _.BookStatus).ToList();
                    break;
                case "Keeper_desc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderByDescending(_ => _.BookKeeper).ToList();
                    break;
                case "Keeper_asc":
                    bookDataCollection.cBookDatumViewModels = bookData.OrderBy(_ => _.BookKeeper).ToList();
                    break;
                default:
                    bookDataCollection.cBookDatumViewModels = bookData;
                    break;
            }
           
           
            return View(bookDataCollection);
        }

        public void setTempData(CBookDatumViewModel cbdvm) {
            #region
            ///記前端的字因為會跳檔所以只能用tempdata
            ///
            TempData["bookName"] = cbdvm.BookName;
            TempData["bookClassID"] = cbdvm.BookClassId;
            TempData["keeper"] = cbdvm.BookKeeper;
            TempData["keepStatus"] = cbdvm.BookStatus;

            #endregion
        }
        public IActionResult Search(CBookDatumViewModel cbdvm)
        {

            setTempData(cbdvm);



            return RedirectToAction("index", "home");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}