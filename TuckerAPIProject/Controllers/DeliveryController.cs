namespace TuckerAPIProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;

    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private DbContext dbContext;

        public DeliveryController(DbContext dbContext) 
        { 
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("[controller]/{date}/{userName}")]
        public DeliveryDto? Get(DateTime date, string userName)
        {
            return this.dbContext.Delivery.Where(_ => _.Date == date && _.Account.UserName == userName).FirstOrDefault();
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