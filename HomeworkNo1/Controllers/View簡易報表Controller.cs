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
        //private 客戶資料Entities db = new 客戶資料Entities();
        private View簡易報表Repository repo = RepositoryHelper.GetView簡易報表Repository();

        // GET: View簡易報表
        public ActionResult Index()
        {
            return View(repo.All());
        }

        public ActionResult Excel()
        {
            if (Request.Browser.Browser == "IE" && Convert.ToInt32(Request.Browser.MajorVersion) < 9)
            {
                return File(repo.Excel(), "application/vnd.ms-excel", Server.UrlPathEncode("簡易報表.xls"));
            }
            else
            {
                return File(repo.Excel(), "application/vnd.ms-excel", "簡易報表.xls");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ((客戶資料Entities)repo.UnitOfWork.Context).Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
