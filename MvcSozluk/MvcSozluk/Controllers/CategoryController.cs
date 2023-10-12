﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozluk.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        //business layer'dan cagırdık.
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
         //   var categoryvalues = cm.GetAllBL();
            return View();
        }
        [HttpGet]
        public ActionResult AddCategory() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
           // cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}