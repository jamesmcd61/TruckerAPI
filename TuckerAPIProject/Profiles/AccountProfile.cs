namespace TuckerAPIProject.Profiles
{
    using AutoMapper;

    using TuckerAPIProject.Dto;
    using TuckerAPIProject.Models;

    public class AccountProfile : Profile
    {
        public AccountProfile() 
        {
            CreateMap<AccountDto, AccountModel>();
        }
    }
}
