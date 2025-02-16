using AutoMapper;
using Web_MVC_EFB4.Domain;
using Web_MVC_EFB4.Models;

namespace Web_MVC_EFB4.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }

}
