using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProgramController : Controller
    {
        // GET: Program
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult StartPetition()
        {
            return View();
        }

        public ActionResult Petition()
        {
            return View();
        }


        public ActionResult Partnerships()
        {
            return View();
        }

        public ActionResult Stories()
        {
            return View();
        }

        public ActionResult UserCreateStories()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Read()
        {
            return View();
        }

        public ActionResult SignPetition()
        {
            ViewBag.Message = "Congratulations!! You have signed this petition.";
            return View();
        }

        public ActionResult LogIn2()
        {
            return View();
        }

        public ActionResult SignUp2()
        {
            return View();
        }

        public ActionResult More()
        {
            return View();
        }

        public ActionResult MoreS()
        {
            return View();
        }
    }
}

/*Buttons:    <button type="submit" class="btn btn-primary" onclick="@Url.Action("StartPetition", "Program") " value="Submit">Add</button>        
                 <button type = "submit" class="btn btn-primary" onclick="@("window.location.href='" + Url.Action("StartPetition", "Program") + "'")" value="Cancel">Cancel</button>*/
        
