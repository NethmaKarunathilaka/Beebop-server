using AutoMapper;
using Bee_bop.Models;
using Bee_bop.Models.Dtos;
namespace Bee_bop.MapperProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserRegDto, User>();
            CreateMap<MessageSendDto, Message>();
        }
    }
}
