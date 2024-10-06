namespace TuckerAPIProject.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;

    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;

    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;

        public DeliveryController(DbContext dbContext, IMapper mapper) 
        { 
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]/{date}/{userName}")]
        public DeliveryDto? Get(DateTime date, string userName)
        {
            var delivery = this.dbContext.Delivery.Where(_ => _.Date == date && _.Account.UserName == userName).FirstOrDefault();
            return this.mapper.Map<DeliveryDto>(delivery);
        }

        [HttpPost]
        [Route("[controller]")]
        public void Post(DeliveryDto delivery)
        {
            this.dbContext.Set<DeliveryDto>().Add(delivery);
            this.dbContext.SaveChangesAsync();
        }

        [HttpPatch]
        [Route("[controller]")]
        public void Patch(DeliveryDto delivery)
        {
            this.dbContext.Set<DeliveryDto>().Update(delivery);
            this.dbContext.SaveChangesAsync();
        }
    }; 
}