namespace HomeworkNo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人: IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            客戶聯絡人Repository repo = RepositoryHelper.Get客戶聯絡人Repository();

            if (repo.相同聯絡人(Id, 客戶Id, Email))
            {
                yield return new ValidationResult("同一個客戶的聯絡人 EMail 重覆！", new string[] { "Email" });
            }

            //db.Dispose();
            ((客戶資料Entities)repo.UnitOfWork.Context).Dispose();
        }
    }
    
    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int 客戶Id { get; set; }

        [Required(ErrorMessage = "請輸入職稱！")]
        [StringLength(50, ErrorMessage = "職稱最多輸入 50 個字！")]
        public string 職稱 { get; set; }

        [Required(ErrorMessage = "請輸入姓名！")]
        [StringLength(50, ErrorMessage = "姓名最多輸入 50 個字！")]
        public string 姓名 { get; set; }

        [Required(ErrorMessage = "請輸入 EMail！")]
        [StringLength(250, ErrorMessage = "EMail 最多輸入 250 個字！")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "EMail 格式錯誤！")]
        [Remote("CheckRepeatEMail", "Validate", AdditionalFields = "Id,客戶Id", ErrorMessage = "同一個客戶的聯絡人 EMail 重覆！")]
        public string Email { get; set; }

        [RegularExpression(@"09\d{2}-\d{6}", ErrorMessage = "手機格式為 0912-345678！")]
        public string 手機 { get; set; }

        [StringLength(50, ErrorMessage = "電話最多輸入 50 個字！")]
        public string 電話 { get; set; }

        [Required]
        public bool 是否已刪除 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
