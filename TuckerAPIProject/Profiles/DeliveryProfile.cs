namespace TuckerAPIProject.Profiles
{
    using AutoMapper;
    using TuckerAPIProject.Dto;
    using TuckerAPIProject.Models;

    public class DeliveryProfile : Profile
    {
        public DeliveryProfile() 
        {
            CreateMap<DeliveryDto, DeliveryModel>();
        }
    }
}
