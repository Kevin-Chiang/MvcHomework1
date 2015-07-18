using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeworkNo1.Models
{   
	public class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{

        public override IQueryable<客戶資料> All()
        {
            return base.All().Where(c => c.是否已刪除 == false);
        }
        
        public IQueryable<客戶資料> 取得前n筆資料(int n)
        {
            return this.All().Where(c => c.是否已刪除 == false).Take(n);
        }

        public 客戶資料 Find(int? id)
        {
            return this.All().FirstOrDefault(c => c.Id == id);
        }

        public override void Add(客戶資料 entity)
        {
            base.Add(entity);
        }

        public override void Delete(客戶資料 entity)
        {
            entity.是否已刪除 = true;
        }

	}

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}