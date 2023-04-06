using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppSecurityExample01.BLL;
using System.Web.Security;

namespace AppSecurityExample01.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Login, string Senha, string returnUrl)
        {
            UsuarioBLL usuarioBll = new UsuarioBLL();
            if (usuarioBll.Login(Login, Senha))
            {
                FormsAuthentication.SetAuthCookie(Login, false);
                if (Url.IsLocalUrl(returnUrl) && !string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View((object)"Login e/ou senha inválidos.");
            }
        }

    }
}
