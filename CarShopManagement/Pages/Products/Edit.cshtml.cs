using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Interface;

namespace CarShopManagement.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly IProductRepository _productRepository;

        public EditModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [BindProperty]
        public Product Product { get; set; }

        public void OnGet(int id)
        {
            Product = _productRepository.GetProductById(id);
        }

        public IActionResult OnPost(string name, int price)
        {
            _productRepository.Edit(Product.ID, name, price);
            return RedirectToPage("Index");
        }
    }
}
