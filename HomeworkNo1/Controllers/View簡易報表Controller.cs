using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeworkNo1.Models;

namespace HomeworkNo1.Controllers
{
    public class View簡易報表Controller : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: View簡易報表
        public ActionResult Index()
        {
            return View(db.View簡易報表.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
