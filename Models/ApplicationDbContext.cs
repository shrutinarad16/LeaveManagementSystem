using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LeaveApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }
    }
}
