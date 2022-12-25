using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestWork3.Data.Models;
using TestWork3.Domain.Types;

namespace TestWork3.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Employee>().Property(employee => employee.Gender).HasConversion(new EnumToStringConverter<GenderType>());
        base.OnModelCreating(builder);
    }

    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Division> Divisions { get; set; }
}