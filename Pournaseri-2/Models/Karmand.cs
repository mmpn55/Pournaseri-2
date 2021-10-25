using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pournaseri_2.Models
{
    public class Karmand
    {
        public int KarmandId { get; set; }
        public string KarmandName { get; set; }
        public int KarmandSalary { get; set; }
    }

    public class MyContext : DbContext
    {

        public MyContext() : base("Server=.;Database=Pournaseri;Trusted_Connection=True;")

        {

        }

        public DbSet<Karmand> Karmands { get; set; }
    }
}
