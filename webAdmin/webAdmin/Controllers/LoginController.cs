using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webAdmin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {

            if (ModelState.IsValid)
            {
                var tkData = new QLBanHangEntities().TaiKhoans;
                var count = tkData.Count(x => x.ID.ToLower() == model.UserName.ToLower() && x.PW == model.Password);
                if (count > 0)
                {
                    //return RedirectToAction("Index", "Home");
                    return View();
                }
            }
            return View();
        }

    }
}
