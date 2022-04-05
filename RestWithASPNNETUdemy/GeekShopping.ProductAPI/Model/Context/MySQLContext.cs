using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Notebook 14'",
                CategoryName = "Eletronicos",
                Description = "Notebook ideapad S145 com melhor custo benêficios",
                Price = new decimal(6500.59),
                ImageUrl = "//"
            });
        }
    }
}
