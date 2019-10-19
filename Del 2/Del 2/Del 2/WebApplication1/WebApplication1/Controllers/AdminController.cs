using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }

        public ActionResult FormsCreate()
        {
            return View();
        }

        public ActionResult FormsUpdate()
        {
            ViewBag.Message = "Are you sure of your choice?";
            return View();
        }

        public ActionResult FormsDelete()
        {
            ViewBag.Message = "Are you sure of your choice?";
            return View();
        }

        public ActionResult Parttnerships()
        {
            return View();
        }

        public ActionResult ParttnershipsCreate()
        {
            return View();
        }

        public ActionResult ParttnershipsUpdate()
        {
            ViewBag.Message = "Are you sure of your choice";
            return View();
        }

        public ActionResult ParttnershipsDelete()
        {
            ViewBag.Message = "Are you sure of your choice";
            return View();
        }

        public ActionResult Petitions()
        {
            return View();
        }

        public ActionResult PetitionsCreate()
        {
            return View();
        }

        public ActionResult PetitionsUpdate()
        {
            ViewBag.Message = "Are you sure of your choice";
            return View();
        }

        public ActionResult PetitionsDelete()
        {
            ViewBag.Message = "Are you sure of your choice";
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult UsersCreate()
        {
            return View();
        }

        public ActionResult UsersUpdate()
        {
            ViewBag.Message = "Are you sure of your choice";
            return View();
        }

        public ActionResult UsersDelete()
        {
            ViewBag.Message = "Are you sure of your choice";
            return View();
        }

        public ActionResult Stories()
        {
            return View();
        }

        public ActionResult StoriesCreate()
        {
            return View();
        }

        public ActionResult StoriesUpdate()
        {
            ViewBag.Message = "Are you sure of your choice";
            return View();
        }

        public ActionResult StoriesDelete()
        {
            ViewBag.Message = "Are you sure of your choice";
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }
    }
}