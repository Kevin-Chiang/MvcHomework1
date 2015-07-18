namespace HomeworkNo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料
    {
    }
    
    public partial class 客戶資料MetaData
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "請輸入客戶名稱！")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "客戶名稱最少輸入 1 個字，最多 50 個字！")]
        public string 客戶名稱 { get; set; }

        [Required(ErrorMessage = "請輸入統一編號！")]
        [RegularExpression(@"\d{8}", ErrorMessage = "統一編號應為 8 個數字！")]
        public string 統一編號 { get; set; }

        [Display(Name = "手機")]
        [Required(ErrorMessage = "請輸入手機！")]
        [RegularExpression(@"09\d{2}-\d{6}", ErrorMessage = "手機格式為 0912-345678！")]
        public string 電話 { get; set; }

        [StringLength(50, ErrorMessage = "傳真最多輸入 50 個字！")]
        public string 傳真 { get; set; }
        
        [StringLength(100, ErrorMessage = "地址最多輸入 100 個字！")]
        public string 地址 { get; set; }

        [Required(ErrorMessage = "請輸入 EMail！")]
        [StringLength(250, ErrorMessage = "EMail 最多輸入 250 個字！")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "EMail 格式錯誤！")]
        public string Email { get; set; }
        
        [Required]
        public bool 是否已刪除 { get; set; }
    
        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}
