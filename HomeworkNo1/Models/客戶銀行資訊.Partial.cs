namespace HomeworkNo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶銀行資訊MetaData))]
    public partial class 客戶銀行資訊
    {
    }
    
    public partial class 客戶銀行資訊MetaData
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int 客戶Id { get; set; }

        [Required(ErrorMessage = "請輸入銀行名稱！")]
        [StringLength(50, ErrorMessage = "銀行名稱不可超過 50 個字！")]
        public string 銀行名稱 { get; set; }

        [Required(ErrorMessage = "請輸入銀行代碼！")]
        [RegularExpression(@"\d{3}", ErrorMessage = "銀行代碼應為 3 個數字！")]
        public string 銀行代碼 { get; set; }

        [RegularExpression(@"\d{4}", ErrorMessage = "分行代碼應為 4 個數字！")]
        public string 分行代碼 { get; set; }

        [Required(ErrorMessage = "請輸入帳戶名稱！")]
        [StringLength(50, ErrorMessage = "帳戶名稱不可超過 50 個字！")]
        public string 帳戶名稱 { get; set; }

        [Required(ErrorMessage = "請輸入帳戶號碼！")]
        [StringLength(20, ErrorMessage = "帳戶名稱不可超過 20 個字！")]
        public string 帳戶號碼 { get; set; }

        [Required]
        public bool 是否已刪除 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
