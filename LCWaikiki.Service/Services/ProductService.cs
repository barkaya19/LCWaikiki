using LCWaikiki.Data.Entities;
using LCWaikiki.Data.IRepositories;
using LCWaikiki.Data.UnitOfWorks;
using LCWaikiki.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCWaikiki.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IGenericRepository<Product> repository) : base(unitOfWork, repository)
        {
        }
    }
}
