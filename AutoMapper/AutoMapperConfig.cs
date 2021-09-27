using APet.App.Models;
using APet.App.ViewModels;
using AutoMapper;

namespace APet.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Pet, PetViewModel>().ReverseMap();
        }
    }
}
