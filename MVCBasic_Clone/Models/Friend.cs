using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasic_Clone.Models
{
    public class Friend
    {
            
            //[Display(Name = "員工編號")]
            public string Id { get; set; }
            //[Display(Name = "名稱")]
            public string Name { get; set; }
            //[Display(Name = "電話")]
            public string Phone { get; set; }
            //[Display(Name = "E-mail")]
            public string Email { get; set; }
            public string City { get; set; }

    }
}