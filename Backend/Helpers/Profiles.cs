using AutoMapper;
using Backend.DTO;
using Backend.DTO.AccountDTO;

namespace Backend.Helpers
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<UserRegister, UserCredentials>();
            
        }
    }
}
