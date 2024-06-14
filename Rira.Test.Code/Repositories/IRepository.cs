using Rira.Test.Code.Models;

namespace Rira.Test.Code.Repositories;

public interface IRepository
    {
    public List<Product> Products { get; }

    public int ProductCount { get; }
    }