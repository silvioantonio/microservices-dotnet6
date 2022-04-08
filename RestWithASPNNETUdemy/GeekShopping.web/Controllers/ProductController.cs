using GeekShopping.web.Models;
using GeekShopping.web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> ProductIndex()
        {
            var products = await _productService.FindAllProducts();
            return View("index", products);
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.CreateProduct(productModel);
                if (response != null)
                {
                    return RedirectToAction(nameof(ProductIndex));
                }
            }
            return View(productModel);
        }

        public async Task<IActionResult> ProductUpdate(int id)
        {
            var response = await _productService.FindProductById(id);
            if (response != null)
            {
                return View(response);
            }
            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> ProductUpdate(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.UpdateProduct(productModel);
                if (response != null)
                {
                    return RedirectToAction(nameof(ProductIndex));
                }
            }
            return View(productModel);
        }

        [HttpDelete]
        public async Task<IActionResult> OnPostProductDelete(int id)
        {
            var response = await _productService.DeleteProductById(id);
            if (response)
            {
                return RedirectToAction(nameof(ProductIndex));
            }
            return NotFound();
        }
    }
}
