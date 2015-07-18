using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeworkNo1.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        public override IQueryable<客戶銀行資訊> All()
        {
            return base.All().Where(銀行 => 銀行.客戶資料.是否已刪除 == false && 銀行.是否已刪除 == false);
        }

        public 客戶銀行資訊 Find(int? Id)
        {
            return this.All().FirstOrDefault(銀行 => 銀行.Id == Id && 銀行.是否已刪除 == false);
        }
	}

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}