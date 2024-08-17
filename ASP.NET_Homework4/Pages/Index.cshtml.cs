using ASP.NET_Homework4.Entities;
using ASP.NET_Homework4.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;

namespace ASP.NET_Homework4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _productService.GetAllAsync();
        }

        [BindProperty]
        public Product Product { get; set; }

        public IActionResult OnPostAddProductAsync()
        {
            _productService.AddAsync(Product);
            Products = _productService.GetAllAsync();
            return RedirectToPage();
        }

        [BindProperty]
        public Product EditProduct { get; set; }

        public IActionResult OnPostEditProductAsync(int id)
        {
            EditProduct = _productService.GetByIdAsync(id);
            Products = _productService.GetAllAsync();
            return Page();
        }

        public IActionResult OnPostUpdateProductAsync()
        {
            
            _productService.UpdateAsync(EditProduct);
            Products = _productService.GetAllAsync();

            return RedirectToPage();
        }

        

        public IActionResult OnPostDelete()
        {
            var id = Request.Form["id"];
            if (int.TryParse(id, out int productId))
            {
                _productService.DeleteAsync(productId);
                
            }

            return RedirectToPage("Index");
        }

    }
}
