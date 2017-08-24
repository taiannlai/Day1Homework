using MyBookkeeping.Models;
using MyBookkeeping.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MyBookkeeping.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookkeepingService _BookkeepingService;
        private int pageSize = 5;
        public HomeController()
        {
            _BookkeepingService = new BookkeepingService();
        }


        public ActionResult Index(int page = 1)
        {
            var Item = new BookkeePingViewModels();
            var book_list = new List<BookkeePing>();
            var service = new BookkeepingService();
            var data = service.GetData();
            var data1 = data.OrderByDescending(x => x.Dateee);
            

            foreach (var item in data1)
            {
                var book = new BookkeePing();
                book.Type = item.Categoryyy == 0 ? "支出" : "收入";
                book.DateTimes = item.Dateee;
                book.Payment = item.Amounttt;
                book_list.Add(book);
            }

            Item.Item = book_list;

            return View(Item);
        }
        public ActionResult Creater()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Creater([Bind(Include = "Id,Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook mybookkeeping)
        {
            if (ModelState.IsValid)
            {
                _BookkeepingService.Add(mybookkeeping);
                _BookkeepingService.Save();
   
                return View();

            }

            return View(mybookkeeping);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}