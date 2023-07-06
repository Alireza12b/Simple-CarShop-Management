using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Interface;

namespace CarShopManagement.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly IProductRepository _productRepository;
        private readonly IWebHostEnvironment _webHostEnvironment1;
        
        public EditModel(IProductRepository productRepository, IWebHostEnvironment webHostEnvironment)
        {
            _productRepository = productRepository;
            _webHostEnvironment1 = webHostEnvironment;
        }

        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public Product Photo { get; set; }

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
