using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecondWeb.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<OurPortfolio> OurPortfolio { get; set; }
        public virtual DbSet<Home> Home { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<TheTeam> TheTeam { get; set; }
        public virtual DbSet<Services> Services { get; set; }


    }
}