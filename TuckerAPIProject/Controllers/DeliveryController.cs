namespace TuckerAPIProject.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;

    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;
    using TuckerAPIProject.Models;

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
        public async Task<IActionResult> Post(DeliveryDto delivery)
        {
            var deliveryToSave = this.mapper.Map<DeliveryModel>(delivery);
            this.dbContext.Set<DeliveryModel>().Add(deliveryToSave);
            await this.dbContext.SaveChangesAsync();
            return Ok();
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