using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using CryptoCurrencyServicesMVC.Models;

namespace CryptoCurrencyServicesMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult WhyUs()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registartion()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(TblRegister tblRegister)
        {
            using(CryptoCurrencyDataEntities db=new CryptoCurrencyDataEntities())
            {
                if(ModelState.IsValid)
                {
                    var obj = db.TblRegisters.Where(a => a.userName.Equals(a.userName) && a.password.Equals(a.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        return RedirectToAction("Info");
                    }
                    db.SaveChanges();
                }
            }

            return View(tblRegister);
        }
        [HttpPost]
        public ActionResult Registartion( TblRegister tblRegister)
        {
            using(CryptoCurrencyDataEntities db=new CryptoCurrencyDataEntities())
            {
                if(ModelState.IsValid)
                {
                    db.TblRegisters.Add(tblRegister);
                    db.SaveChanges();
                    ViewBag.Message("Registartion Sucessfully");
                    ModelState.Clear();
                        
                }
            }


            return View(tblRegister);
        }

        [HttpPost]
        public ActionResult Info(CryptoTbl cryptoTbl)
        {
            using (CryptoCurrencyDataEntities db = new CryptoCurrencyDataEntities())
            {
                if (ModelState.IsValid)
                {
                    db.CryptoTbls.Add(cryptoTbl);
                    db.SaveChanges();
                    ViewBag.Message("Success");
                    ModelState.Clear();

                }
            }

            return View(cryptoTbl);
        }

    }
}