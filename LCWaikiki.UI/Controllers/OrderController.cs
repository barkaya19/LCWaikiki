using LCWaikiki.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace LCWaikiki.UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAllAsync());
        }
    }
}
