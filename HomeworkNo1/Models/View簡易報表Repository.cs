using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using NPOI.HSSF.UserModel;
	
namespace HomeworkNo1.Models
{   
	public  class View簡易報表Repository : EFRepository<View簡易報表>, IView簡易報表Repository
	{
        public byte[] Excel()
        {
            HSSFWorkbook workBook = new HSSFWorkbook();
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // 新增試算表。 
                    var sheet = workBook.CreateSheet("簡易報表");

                    // 建立表頭
                    var rowTitle = sheet.CreateRow(0);
                    rowTitle.CreateCell(0).SetCellValue("客戶名稱");
                    rowTitle.CreateCell(1).SetCellValue("聯絡人數量");
                    rowTitle.CreateCell(2).SetCellValue("銀行帳戶數量");

                    // Loop，建立內容
                    foreach (var item in this.All())
                    {
                        var rowData = sheet.CreateRow(sheet.LastRowNum + 1);
                        rowData.CreateCell(0).SetCellValue(item.客戶名稱);
                        rowData.CreateCell(1).SetCellValue((int)item.ContactCnt);
                        rowData.CreateCell(2).SetCellValue((int)item.BankCnt);                        
                    }

                    workBook.Write(ms);
                    return ms.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                workBook = null;
            }
        }
	}

	public  interface IView簡易報表Repository : IRepository<View簡易報表>
	{

	}
}