namespace TuckerAPIProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;

    [ApiController]
    public class PackageController : ControllerBase
    {
        private DbContext dbContext;

        public PackageController(DbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("[controller]/{name}")]
        public PackageDto? Get(string name)
        {
            return this.dbContext.Package.Where(_ => _.Name == name).FirstOrDefault();
        }
    }
}
