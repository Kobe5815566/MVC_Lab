using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCBasic_Clone.Models
{
    public class HRContext : DbContext
    {
        public HRContext() : base("name=HrDatabase")
        {
            
        }
        public System.Data.Entity.DbSet<Friend> Friends { get; set; }
        public DbSet<Empolyee> Empolyees { get; set; }
    }
}