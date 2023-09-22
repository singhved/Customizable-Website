using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SecondWeb.Models
{
    [Table("Contact")]
    public class Contact
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subjects { get; set; }
        public string Messages { get; set; }
    }
}