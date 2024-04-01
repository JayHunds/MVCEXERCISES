using MVCExercise.Models;

namespace MVCExercise.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
