using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if(context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "React",
                    Description = "Learn React",
                    Price = 1000,
                    PictureUrl = "/images/products/react.png",
                    Brand = "React association",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular",
                    Description = "Learn Angular",
                    Price = 800,
                    PictureUrl = "/images/products/angular.png",
                    Brand = "Angular association",
                    Type = "Online",
                    QuantityInStock = 250
                },
                new Product
                {
                    Name = "Dotnet",
                    Description = "Learn Dotnet",
                    Price = 800,
                    PictureUrl = "/images/products/dotnet.png",
                    Brand = "Micro Soft",
                    Type = "Hybrid",
                    QuantityInStock = 50
                }
            };

            foreach(var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}