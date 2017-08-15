using MyBookkeeping.Models;
using MyBookkeeping.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBookkeeping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Item = new BookkeePingViewModels();
            var book_list = new List<BookkeePing>();
            var service = new BookkeepingService();
            var data = service.GetData();

            foreach (var item in data)
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