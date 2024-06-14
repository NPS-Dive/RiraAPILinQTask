using Rira.Test.Code.Models;
using Rira.Test.Code.Repositories;
using Rira.Test.Code.Services.Contracts;

namespace Rira.Test.Code.Services.Services;

public class ProductService : IProductService
    {
    private readonly IRepository _repository;

    public ProductService ( IRepository repository )
        {
        _repository = repository;
        }


    /// <summary>
    /// لیست محصولات دسته 1
    /// </summary>
    /// <returns></returns>
    public List<Product> GetByCategory ( CategoryType category )
        {
        var listOfCategory1 = _repository.Products.Where(product => product.Category == category).ToList();
        return listOfCategory1;
        }


    /// <summary>
    /// 2 گرانترین محصول
    /// </summary>
    /// <returns></returns>
    public Product MostExpensiveProduct ()
        {
        var sortByPrice = _repository.Products.OrderByDescending(product => product.Price);

        return sortByPrice.First();
        }


    /// <summary>
    /// 3 مجموع قیمتهای محصولات
    /// </summary>
    /// <returns></returns>
    public double TotalPrice ()
        {
        var totalPrice = _repository.Products.Sum(item => item.Price);

        return totalPrice;
        }

    /// <summary>
    /// 4 گروه بندی بر اساس دسته
    /// </summary>
    /// <returns></returns>
    public List<IGrouping<CategoryType, Product>> ProductGrouping ()
        {
        var grouping = _repository.Products.GroupBy(product => product.Category);
        return grouping.ToList();
        }


    /// <summary>
    /// 5 میانگین قیمتهای محصولات
    /// </summary>
    /// <returns></returns>
    public double MeanPrice ()
        {
        var meanOfPrices = TotalPrice() / _repository.ProductCount;

        return meanOfPrices;
        }


    }