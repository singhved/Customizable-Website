using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SecondWeb.Models
{
    [Table("AboutUs")]
    public class AboutUs
    {
        public int id { get; set; }
        public string Heading { get; set; }
        public string Details { get; set; }
    }
}