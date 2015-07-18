using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeworkNo1.Models
{
    public class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
    {
        public override IQueryable<客戶聯絡人> All()
        {
            return base.All().Where(聯絡人 => 聯絡人.客戶資料.是否已刪除 == false && 聯絡人.是否已刪除 == false);
        }

        public 客戶聯絡人 Find(int? Id)
        {
            return this.All().FirstOrDefault(聯絡人 => 聯絡人.客戶資料.是否已刪除 == false && 聯絡人.是否已刪除 == false && 聯絡人.Id == Id);
        }

        public bool 相同聯絡人(int? Id, int 客戶Id, string EMail)
        {
            var 重覆的聯絡人 = this.All().Where(聯絡人 => 聯絡人.客戶Id == 客戶Id && 聯絡人.Email == EMail);
            if (重覆的聯絡人.Count() == 0 || (重覆的聯絡人.Count() == 1 && 重覆的聯絡人.FirstOrDefault().Id == Id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
    {

    }
}