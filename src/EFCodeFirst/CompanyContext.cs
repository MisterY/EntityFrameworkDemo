using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using EFCodeFirst.Model;

namespace EFCodeFirst
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyDatabase") { }

        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}
