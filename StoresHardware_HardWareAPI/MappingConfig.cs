using AutoMapper;
using StoresHardware_HardWareAPI.Models;
using StoresHardware_HardWareAPI.Models.Dto;

namespace StoresHardware_HardWareAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
           
            CreateMap<Shop, ShopDto>().ReverseMap();
            CreateMap<Shop, ShopCreateDto>().ReverseMap();           

            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductCreateDto>().ReverseMap();            

            CreateMap<ProductCategory, ProductCategoryDto>().ReverseMap();  

        }
    }
}
