using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBasic_Clone.Models;
namespace MVCBasic_Clone.Controllers
{
    public class EmployeesController : Controller
    {
        private HRContext db = new HRContext();
        // GET: Employees
        public ActionResult Index()
        {
            var emps = db.Empolyees.ToList();
            //把db.Friends的資料 集合化 => 丟進model
            return View(emps);
        }

        public ActionResult EmployeeList()
        {
            List<Empolyee> empolyees = new List<Empolyee>
            {
                new Empolyee { Id = 10001, Name = "David", Phone = "0933-154228", Email ="david@gmail.com" },
                new Empolyee{ Id = 10002, Name = "Mary", Phone = "0925-157886", Email ="mary@gmail.com" },
                new Empolyee { Id = 10003, Name = "John", Phone = "0921-335884", Email ="john@gmail.com" },
                new Empolyee { Id = 10004, Name = "Cindy", Phone = "0971-628322", Email ="cindy@gmail.com" },
                new Empolyee { Id = 10005, Name = "Rose", Phone = "0933-154228",  Email ="rose@gmail.com" }

            };


            return View(empolyees);
        }
    }
}