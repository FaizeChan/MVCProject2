using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProject2.Models
{
    public class Category
    {
        //Are these places real or not.

        [Key]
        public int ID { get; set; }
        [Display(Name = "Category")]
        public string Name { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}