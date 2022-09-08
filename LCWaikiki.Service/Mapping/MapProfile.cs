using AutoMapper;
using LCWaikiki.Data.Entities;
using LCWaikiki.Service.DTOs;

namespace LCWaikiki.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {

            //dto eklnemesine rağmen kullanılamadı
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Delivery, DeliveryDto>().ReverseMap();
        }
    }
}
