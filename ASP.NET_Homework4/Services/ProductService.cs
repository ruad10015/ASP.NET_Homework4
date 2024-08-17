using ASP.NET_Homework4.Entities;
using ASP.NET_Homework4.Repositories;

namespace ASP.NET_Homework4.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddAsync(Product product)
        {
            _repository.AddAsync(product);
        }

        public void DeleteAsync(int id)
        {
            _repository.DeleteAsync(id);
        }

        public List<Product> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Product GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public void UpdateAsync(Product product)
        {
            _repository.UpdateAsync(product);
        }
    }
}
