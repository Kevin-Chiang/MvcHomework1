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
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        [Required]
        public int ContactCnt { get; set; }
        [Required]
        public int BankCnt { get; set; }
    }
}
