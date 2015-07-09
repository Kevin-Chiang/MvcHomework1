//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeworkNo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class 客戶銀行資訊
    {
        public int Id { get; set; }
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

        public bool 是否已刪除 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
