using Domain.Dto;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController
    {
        private CustomerController _customerService;

        public CustomerController()
        {
            _customerService = new CustomerController();
        }
        [HttpGet("List")]
        public List<Customers> GetCustomers()
        {
            return _customerService.GetCustomers();
        }

        [HttpPost("Insert")]
        public int InsertCustomers(Customers customers)
        {
            return _customerService.InsertCustomers(customers);
        }

        [HttpPut("Update")]
        public int UpdateCustomers(Customers customers)
        {
            return _customerService.UpdateCustomers(customers);
        }

        [HttpDelete("Delete")]
        public int DeleteCustomers(int id)
        {
            return _customerService.DeleteCustomers(id);
        }
    }
}