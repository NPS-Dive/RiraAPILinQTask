using Rira.Test.Code.Models;

namespace Rira.Test.Code.Services.Contracts;

public interface IProductService
    {
    public List<Product> GetByCategory ( CategoryType category );

    public Product MostExpensiveProduct ();

    public double TotalPrice ();

    public List<IGrouping<CategoryType, Product>> ProductGrouping ();

    public double MeanPrice ();
    }