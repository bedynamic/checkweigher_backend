using backend.Models;
using Microsoft.EntityFrameworkCore;
 
public class BackendDbContext : DbContext
{
 public DbSet<TestValue> TestValues { get; set; }
 
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
 optionsBuilder.UseSqlite("Filename=./Backend.db");
 }
}