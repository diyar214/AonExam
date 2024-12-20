using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Controller()]
class ApplicationDbContext : DbContext {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    DbSet<Product> Products { get; set; }
}