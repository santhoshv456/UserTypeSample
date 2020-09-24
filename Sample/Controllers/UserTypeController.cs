using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class UserTypeController : Controller
    {
        UserContext context = new UserContext(); 
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createUserType(UserType ust)
        {
            try
            {
                context.usertype.Add(ust);
                context.SaveChanges();
                string message = "SUCCESS";
                return Json(new { Message = message, JsonRequestBehavior.AllowGet });
            }
            catch(Exception ex)
            {
                string message = "Failed";
                return Json(new { Message = message, JsonRequestBehavior.DenyGet });
            }
            
        }

        public JsonResult getUserType(string utid)
        {
            List<UserType> userTypes = new List<UserType>();
            userTypes = context.usertype.ToList();
            return Json(userTypes, JsonRequestBehavior.AllowGet);
        }


    }
}