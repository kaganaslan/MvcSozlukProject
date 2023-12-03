using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcSozluk.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //Adminden parametre alması için parametre veriyoruz
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserinfo=c.Admins.FirstOrDefault(x=>x.AdminUserName==p.AdminUserName && x.AdminPassword==p.AdminPassword); //first or default geriye bir tane deger dondurmesini istediğimiz zaman kullanıyoyudk.
            if (adminuserinfo != null)
            {
                //yönlendirme işlemleri ve yetkinlendirme işemleri
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUserName,false);
                Session["AdminUserName"]=adminuserinfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");   
            }
            return View();
        }
    }
}