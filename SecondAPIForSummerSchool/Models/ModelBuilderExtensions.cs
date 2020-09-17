using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondAPIForSummerSchool.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Category1" },
                new Category { Id = 2, Name = "Category2" },
                new Category { Id = 3, Name = "Category3" },
                new Category { Id = 4, Name = "Category4" },
                new Category { Id = 5, Name = "Category5" },
                new Category { Id = 6, Name = "Category6" },
                new Category { Id = 7, Name = "Category7" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Product1", Sku = "Sku1", Description = "Desc1", IsAvailable = true, Price = 2020 },
                new Product { Id = 2, CategoryId = 1, Name = "Product2", Sku = "Sku1", Description = "Desc1", IsAvailable = true, Price = 2020 },
                new Product { Id = 3, CategoryId = 1, Name = "Product3", Sku = "Sku1", Description = "Desc1", IsAvailable = true, Price = 2020 },
                new Product { Id = 4, CategoryId = 1, Name = "Product4", Sku = "Sku1", Description = "Desc1", IsAvailable = true, Price = 2020 },
                new Product { Id = 5, CategoryId = 1, Name = "Product5", Sku = "Sku1", Description = "Desc1", IsAvailable = true, Price = 2020 },
                new Product { Id = 6, CategoryId = 1, Name = "Product6", Sku = "Sku1", Description = "Desc1", IsAvailable = true, Price = 2020 },
                new Product { Id = 7, CategoryId = 1, Name = "Product7", Sku = "Sku1", Description = "Desc1", IsAvailable = true, Price = 2020 },
                new Product { Id = 8, CategoryId = 2, Name = "Product8", Sku = "Sku2", Description = "Desc2", IsAvailable = true, Price = 2020 },
                new Product { Id = 9, CategoryId = 2, Name = "Product9", Sku = "Sku2", Description = "Desc2", IsAvailable = true, Price = 2020 },
                new Product { Id = 10, CategoryId = 2, Name = "Product10", Sku = "Sku2", Description = "Desc2", IsAvailable = true, Price = 2020 },
                new Product { Id = 11, CategoryId = 3, Name = "Product10", Sku = "Sku3", Description = "Desc3", IsAvailable = true, Price = 2020 },
                new Product { Id = 12, CategoryId = 3, Name = "Product12", Sku = "Sku3", Description = "Desc3", IsAvailable = true, Price = 2020 },
                new Product { Id = 13, CategoryId = 4, Name = "Product13", Sku = "Sku4", Description = "Desc4", IsAvailable = true, Price = 2020 },
                new Product { Id = 14, CategoryId = 4, Name = "Product14", Sku = "Sku4", Description = "Desc4", IsAvailable = true, Price = 2020 },
                new Product { Id = 15, CategoryId = 4, Name = "Product15", Sku = "Sku4", Description = "Desc4", IsAvailable = true, Price = 2020 },
                new Product { Id = 16, CategoryId = 4, Name = "Product16", Sku = "Sku4", Description = "Desc4", IsAvailable = true, Price = 2020 },
                new Product { Id = 17, CategoryId = 5, Name = "Product17", Sku = "Sku5", Description = "Desc5", IsAvailable = true, Price = 2020 },
                new Product { Id = 18, CategoryId = 5, Name = "Product18", Sku = "Sku5", Description = "Desc5", IsAvailable = true, Price = 2020 },
                new Product { Id = 19, CategoryId = 5, Name = "Product19", Sku = "Sku51", Description = "Desc5", IsAvailable = true, Price = 2020 },
                new Product { Id = 20, CategoryId = 5, Name = "Product20", Sku = "Sku5", Description = "Desc5", IsAvailable = true, Price = 2020 },
                new Product { Id = 21, CategoryId = 5, Name = "Product21", Sku = "Sku5", Description = "Desc5", IsAvailable = true, Price = 2020 }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "user1@use1.user1" },
                new User { Id = 2, Email = "user2@use2.user2" }
             );
        }
    }
}
