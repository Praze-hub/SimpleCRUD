using Microsoft.EntityFrameworkCore;
using App.Models;
namespace App.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<UserData> UserDataTable{get; set;}   
        
     }
}