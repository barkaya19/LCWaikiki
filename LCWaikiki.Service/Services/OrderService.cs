using AutoMapper;
using LCWaikiki.Data.Entities;
using LCWaikiki.Data.IRepositories;
using LCWaikiki.Data.UnitOfWorks;
using LCWaikiki.Service.DTOs;
using LCWaikiki.Service.IServices;

namespace LCWaikiki.Service.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IGenericRepository<Order> repository,IMapper mapper, IOrderRepository orderRepository) :
            base(unitOfWork, repository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }
    }
}
