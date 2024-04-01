using MVCExercise.Models;

namespace MVCExercise.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        void UpdateProduct(Product product);
    }
}
