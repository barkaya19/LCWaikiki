using AutoMapper;
using LCWaikiki.Data.Entities;
using LCWaikiki.Data.IRepositories;
using LCWaikiki.Service.DTOs;
using LCWaikiki.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LCWaikiki.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IOrderService _service;

        public OrderController(IOrderService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Order>),(int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _service.GetAllAsync();
            return Ok(orders);
            
        }


        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(List<OrderDto>);
        //}
    }
}
