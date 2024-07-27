using AutoMapper;

namespace csv_net.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<TesteDTO, Teste>()
                .ReverseMap();
        }
    }
}   