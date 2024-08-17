using ASP.NET_Homework4.Entities;

namespace ASP.NET_Homework4.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllAsync();
        Product GetByIdAsync(int id);
        void AddAsync(Product product);
        void UpdateAsync(Product product);
        void DeleteAsync(int id);
    }
}
