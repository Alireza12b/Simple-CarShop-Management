using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Interface;
using Services.ProductServices;

namespace CarShopManagement.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductRepository _productRepository;
        [BindProperty]
        public IEnumerable<Product> Product { get; set; }

        public IndexModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void OnGet()
        {
            Product = _productRepository.GetAllProduct();
        }

        public IActionResult OnPost(int productid)
        {
            _productRepository.Delete(productid);
            Product = _productRepository.GetAllProduct();
            return RedirectToPage("Index");
        }
    }
}
