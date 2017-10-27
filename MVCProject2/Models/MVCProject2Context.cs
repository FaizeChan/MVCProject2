using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCProject2.Models
{
    public class MVCProject2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCProject2Context() : base("name=MVCProject2Context")
        {
        }

        public System.Data.Entity.DbSet<MVCProject2.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<MVCProject2.Models.Category> Categories { get; set; }
    }
}
