using MVCBasic_Clone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Kevin";

            ViewData["Age"] = 33;
            ViewData["Single"] = true;
            return View();
        }

        public ActionResult PassViewBag()
        {
            ViewBag.NickName = "Mary";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;

            return View();
        }
        public ActionResult PetShop()
        {
            ViewData["Company"] = "汪星人寵物店";
            ViewBag.Address = "台北市信義區松山路100號";
            List<string> petList = new List<string>();
            petList.Add("狗");
            petList.Add("貓");
            petList.Add("魚");
            petList.Add("鼠");
            petList.Add("變色龍");

            ViewData.Model = petList;

            return View();
        }
        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存去系統資料，請聯絡系統";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();

            return RedirectToAction("Error Message", "ErrorHandler");
        }

        public ActionResult PassViewModel()
        {
            PeopleViewModels peopleVM = new PeopleViewModels();
            peopleVM.Employees = null;
            peopleVM.Friends = null;
            return View(peopleVM);
        }
    }
}