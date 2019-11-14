using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBasic_Clone.Models
{
    public class Empolyee
    {   
        [Display(Name = "員工編號")]
        public int Id { get; set; }
        [Display(Name = "名稱")]
        public string Name { get; set; }
        [Display(Name = "電話")]
        public string Phone { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}