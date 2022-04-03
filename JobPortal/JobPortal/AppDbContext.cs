using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("ConnectionString")
        {

        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
