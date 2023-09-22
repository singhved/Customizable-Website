using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SecondWeb.Models
{
    [Table("TheTeam")]
    public class TheTeam
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Details { get; set; }

    }
}