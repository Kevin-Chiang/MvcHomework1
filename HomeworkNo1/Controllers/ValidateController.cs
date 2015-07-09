using HomeworkNo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkNo1.Controllers
{
    public class ValidateController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        public JsonResult CheckRepeatEMail(int 客戶Id, string Email)
        {
            bool IsValidate = false;

            ////利用 IsLocalUrl檢查是否為網站呼叫的
            ////借此忽略一些不必要的流量
            //if (Url.IsLocalUrl(Request.Url.AbsoluteUri))
            //{
            // 查詢有相同 EMail 的聯絡人
            var ContactRepeat = db.客戶聯絡人.ToList()
                                  .Where(Contact => Contact.客戶Id == 客戶Id && Contact.Email == Email);

            //﹝判斷﹞有沒有重覆 EMail 的聯絡人
            if (ContactRepeat.Count() >= 1)
            {
                // EMail 重覆
                IsValidate = false;
            }
            else
            {
                // EMail 沒有重覆
                IsValidate = true;
            }

            //}

            return Json(IsValidate, JsonRequestBehavior.AllowGet);
        }
    }
}