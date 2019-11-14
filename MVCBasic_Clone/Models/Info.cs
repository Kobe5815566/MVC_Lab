using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBasic_Clone.Models
{
    public class Info
    {
        public string Id { get; set; }
        [Display(Name = "名稱")]
        [StringLength(20 , MinimumLength = 3, ErrorMessage ="最少需三個字元") ]
        [Required(ErrorMessage ="名稱必須輸入")]
        public string Name { get; set; }
        [Display(Name = "行動電話")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        [Required(ErrorMessage = "電話必須輸入")]
        public string Phone { get; set; }
        [Display(Name = "電子郵件")]
        [Required(ErrorMessage = "郵件必須輸入")]
        public string Email { get; set; }
        [Display(Name = "性別")]
        [Required(ErrorMessage = "性別必須輸入")]
        public string Gender { get; set; }
        
    }
}