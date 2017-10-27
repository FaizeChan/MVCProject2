using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCProject2.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [MinLength(5), MaxLength(50), Display(Name = "Location's Name")]
        public string Title { get; set; }

        [MinLength(10), MaxLength(100)]
        public string Discription { get; set; }

        [Display(Name = "Why this Location?"), MaxLength(500)]
        public string Reason { get; set; }

        //[ForeignKey] is to connect two classes togther

        [ForeignKey("Category"), Display(Name = "The Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}