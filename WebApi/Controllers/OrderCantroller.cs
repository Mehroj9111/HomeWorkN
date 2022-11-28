using Domain.Dto;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController
    {
        private OrdersController _ordersService;

        public OrdersController()
        {
            _ordersService = new OrdersController();
        }
        [HttpGet("List")]
        public List<Orders> GetOrders()
        {
            return _ordersService.GetOrders();
        }

        [HttpPost("Insert")]
        public int InsertOrders(Orders customers)
        {
            return _ordersService.InsertOrders(customers);
        }

        [HttpPut("Update")]
        public int UpdateOrders(Orders customers)
        {
            return _ordersService.UpdateOrders(customers);
        }

        [HttpDelete("Delete")]
        public int DeleteOrders(int id)
        {
            return _ordersService.DeleteOrders(id);
        }
    }
}