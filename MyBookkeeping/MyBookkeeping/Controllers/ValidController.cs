using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBookkeeping.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        public ActionResult MoneyValid(int amounttt)
        {
            bool isValidate = (amounttt > 0) ? true : false;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DateValid(DateTime Dateee)
        {
            bool isValidate = (Dateee <= DateTime.Today) ? true : false;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RemarkValid(string Remarkkk)
        {
            bool isValidate = (Remarkkk.Length <= 100) ? true : false;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}