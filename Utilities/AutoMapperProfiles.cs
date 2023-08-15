using AutoMapper;
using inter.DTOs;
using inter.Models;

namespace inter.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<TeamsDTO, Teams>();
            CreateMap<PlayerDTO, Players>();
            CreateMap<ManagersDTO, Managers>();
        }
    }
}
