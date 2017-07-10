using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurentApp.BLL;
using RestaurentApp.Models;

namespace RestaurentApp.Controllers
{
    public class MemberController : Controller
    {
        private MemberManager memberManager= new MemberManager();
        private StudentManager studentManager = new StudentManager();
        //
        // GET: /Member/
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult MemberEntry()
        {
            var members = memberManager.GetAll();
            ViewBag.Members = new SelectList(members, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult MemberEntry (Member member)
        {
            if (ModelState.IsValid)
            {
                
            }
            var members = memberManager.GetAll();
            ViewBag.Members = new SelectList(members, "Id", "Name");
            return View();
        }
       
    }
}