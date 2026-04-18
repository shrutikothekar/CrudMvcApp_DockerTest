using CrudMvcApp_DockerTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CrudMvcApp_DockerTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
