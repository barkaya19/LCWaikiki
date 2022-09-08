using LCWaikiki.Data.Entities;
using LCWaikiki.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCWaikiki.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
       
        public OrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
