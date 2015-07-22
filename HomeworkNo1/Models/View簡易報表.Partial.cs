namespace HomeworkNo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(View簡易報表MetaData))]
    public partial class View簡易報表
    {
    }
    
    public partial class View簡易報表MetaData
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 客戶名稱 { get; set; }

        [Required]
        [Display(Name = "聯絡人數量")]
        public int ContactCnt { get; set; }

        [Required]
        [Display(Name = "銀行帳戶數量")]
        public int BankCnt { get; set; }
    }
}
