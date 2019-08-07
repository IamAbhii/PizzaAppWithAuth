using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaHelpCenterAppV1.Controllers
{
    public class HomeController : Controller
    {
        private RoleManager<IdentityRole> rolesManager;
        private UserManager<IdentityUser> usersManager;

        public HomeController()
        {
            rolesManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
            usersManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());
        }
        public ActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddRole(string name)
        {
            if (!rolesManager.RoleExists(name))
            {
                rolesManager.Create(new IdentityRole(name));
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult JoinRole()
        {
            ViewBag.roles = new SelectList(rolesManager.Roles, "Name", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult JoinRole(string roles)
        {

            if (rolesManager.RoleExists(roles))
            {

                var userId = User.Identity.GetUserId();
                usersManager.AddToRole(userId, roles);
                return RedirectToAction("Index");
            }
            return View();
        }
        [Authorize(Roles="Admin,staff")]
        
        //=============================================================================
        public ActionResult Index()
        {
            return View();
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