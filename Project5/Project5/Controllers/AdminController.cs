using Project5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project5.Controllers
{
    public class AdminController : Controller
    {
       
        private ElectionEntities db = new ElectionEntities();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            var admin = db.Admins.SingleOrDefault(u => u.username == Username);
            if (admin != null && admin.password == Password)
            {
                Session["id"] = admin.id;
                return RedirectToAction("Index", "Admin");
            }
            ViewBag.ErrorMessage = "Invalid Username or password.";
            return View();
        }
        public ActionResult Index()
        {
            if (Session["id"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
       

        public ActionResult Logout()
        {
            Session["id"] = null;
            return RedirectToAction("Index", "Admin");
        }

        public ActionResult Profile()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
        public ActionResult LocalListsApplications()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
        public ActionResult PartyListsApplications()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
        public ActionResult ADsApplications()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
        public ActionResult DebatesApplications()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
        public ActionResult Results()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
        public ActionResult Feedbacks()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
        public ActionResult ViewCandedates()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
        public ActionResult AddAdmins()
        {
            var id = Session["id"];
            var admin = db.Admins.Find(id);
            return View(admin);
        }
    }
}