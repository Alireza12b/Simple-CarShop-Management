using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Interface;

namespace CarShopManagement.Pages.Products
{
    public class ShowDataModel : PageModel
    {
        private readonly IProductRepository _productRepository;

        public ShowDataModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [BindProperty]
        public Product Product { get; set; }

        public IActionResult OnGet(int id)
        {
            Product = _productRepository.GetProductById(id);
            if (Product == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
