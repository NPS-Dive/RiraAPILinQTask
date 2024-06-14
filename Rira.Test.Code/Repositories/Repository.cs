using Rira.Test.Code.Models;

namespace Rira.Test.Code.Repositories;

public class Repository : IRepository
    {
    public List<Product> Products => new()
        {
            new Product {Id=1, Name = "Product A",Category = CategoryType.Category1,Price = 100},
            new Product {Id=2, Name = "Product A",Category = CategoryType.Category1,Price = 150},
            new Product {Id=3, Name = "Product A",Category = CategoryType.Category2,Price = 120},
            new Product {Id=4, Name = "Product A",Category = CategoryType.Category3,Price = 200},
            new Product {Id=5, Name = "Product A",Category = CategoryType.Category1,Price = 80},
        };

    public int ProductCount => Products.Count();
    }