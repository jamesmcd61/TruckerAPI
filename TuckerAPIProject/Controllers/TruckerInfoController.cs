namespace TuckerAPIProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;

    [ApiController]
    public class TruckerInfoController : ControllerBase
    {
        private DbContext dbContext;

        public TruckerInfoController(DbContext dbContext) 
        { 
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("[controller]/{name}")]
        public TruckerInfoDto? Get(string name)
        {
            return this.dbContext.TruckerInfo.Where(_ => _.Name == name).FirstOrDefault();
        }
    }
}
