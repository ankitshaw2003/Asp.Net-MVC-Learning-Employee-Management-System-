using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

using System.Web.Configuration;
using System.Web.Security;
using System.Drawing;

using System.EnterpriseServices;

using System.Web.UI.WebControls;

using System.Windows;
using System.Runtime.Remoting;

using System.IO;
using System.Drawing.Printing;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        testEntities db = new testEntities();
        public ActionResult Index()
        {
            return View("View");
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult employeeInformation()
         {
            Employee employee = new Employee();
            employee.Employees = db.tblemployeemsts.ToList();
            return View(employee);
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        public ActionResult findDetails(int? id) {
            Employee employee = new Employee();
            employee.Employees = db.tblemployeemsts.Where(x => x.id == id).ToList();
            return View(employee);
        }
        public ActionResult Update(int? id)
        {
            var employee = db.tblemployeemsts.FirstOrDefault(x => x.id == id);
            return View(employee);
        }
        [HttpPost]
        public JsonResult PostUsingStronglyBinding(Employee emp)
        {
            if (ModelState.IsValid)
            {
                var createemployee = db.tblemployeemsts.Create();
                createemployee.name = emp.Name;
                createemployee.address = emp.Address;
                db.tblemployeemsts.Add(createemployee);
                db.SaveChanges();
                return Json(new { success = true, redirectUrl = Url.Content("~/student/Information") });


            }
            return Json(new { success = true, redirectUrl = Url.Content("~/student/addEmployee") });
        }
        [HttpPost]
        public ActionResult UpdateUsingStronglyBinding(Employee emp)
        {
            var data = new tblemployeemst();
            if (ModelState.IsValid)
            {
                data.id = emp.Id;
                data.name = emp.Name;
                data.address = emp.Address;
                db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return View();
            }
            return View("Update",data);
        }
        [HttpGet]
        public ActionResult Delete(int Id) {
            var emp = new tblemployeemst() {id = Id};
            db.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            Employee employee = new Employee();
            employee.Employees = db.tblemployeemsts.ToList();
            return View("employeeInformation",employee);
        }
    }
}