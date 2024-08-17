using ASP.NET_Homework4.Data;
using ASP.NET_Homework4.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Homework4.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDbContext _contex;
        public EFProductRepository(ProductDbContext contex)
        {
            _contex = contex;
        }

        public void AddAsync(Product product)
        {
            _contex.Products.Add(product);
            _contex.SaveChanges();

        }

        public void DeleteAsync(int id)
        {
            var product = _contex.Products.Where(p => p.Id == id).SingleOrDefault();

            if (product != null)
            {
                _contex.Products.Remove(product);
                _contex.SaveChanges();
            }
        }

        public List<Product> GetAllAsync()
        {
            return _contex.Products.ToList();
        }

        public Product GetByIdAsync(int id)
        {
            return _contex.Products.Where(p => p.Id == id).SingleOrDefault();

        }

        public void UpdateAsync(Product product)
        {
            _contex.Products.Update(product);
            _contex.SaveChanges();
        }
    }
}
