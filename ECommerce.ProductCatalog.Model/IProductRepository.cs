using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///     Interface to store Products in stateful service data store. Needs to implement an Add and a Get. All methods are Async and return a Task
/// </summary>
namespace ECommerce.ProductCatalog.Model
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task AddProduct(Product product);
    }
}
