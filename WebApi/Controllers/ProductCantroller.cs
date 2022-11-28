using Domain.Dto;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private ProductController _productsService;

        public ProductController()
        {
            _productsService = new ProductController();
        }
        [HttpGet("List")]
        public List<Products> GetProduct()
        {
            return _productsService.GetProduct();
        }

        [HttpPost("Insert")]
        public int InsertProducts(Products customers)
        {
            return _productsService.InsertProducts(customers);
        }

        [HttpPut("Update")]
        public int UpdateProducts(Products customers)
        {
            return _productsService.UpdateProducts(customers);
        }

        [HttpDelete("Delete")]
        public int DeleteProducts(int id)
        {
            return _productsService.DeleteProducts(id);
        }
    }
}