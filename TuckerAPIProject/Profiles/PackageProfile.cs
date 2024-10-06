namespace TuckerAPIProject.Profiles
{
    using AutoMapper;
    using TuckerAPIProject.Dto;
    using TuckerAPIProject.Models;

    public class PackageProfile : Profile
    {
        public PackageProfile() 
        { 
            CreateMap<PackageDto, PackageModel>();
        }
    }
}
