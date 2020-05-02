using DAL.Models;

namespace DAL
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext: DbContext
    {
        public DbSet<Dish> Users { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=remotemysql.com;port=3306;UserId=ZQKPpP9LHh;Password=8LaCm5QmXG;database=ZQKPpP9LHh;");
        }
    }
}