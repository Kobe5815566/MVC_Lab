using MVCBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasic_Clone.ViewModels
{
    public class PeopleViewModels
    {
        public List<Empolyee> Employees { get; set; }
        public List<Friend> Friends { get; set; }
    }
}