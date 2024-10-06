namespace TuckerAPIProject.Profiles
{
    using AutoMapper;
    using TuckerAPIProject.Dto;
    using TuckerAPIProject.Models;

    public class TruckerInfoProfile : Profile
    {
        public TruckerInfoProfile() 
        { 
            CreateMap<TruckerInfoDto, TruckerInfoModel>();
        }
    }
}
