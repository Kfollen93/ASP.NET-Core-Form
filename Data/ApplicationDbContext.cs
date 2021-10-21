using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormTemplateProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FormTemplateProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
    }
}
