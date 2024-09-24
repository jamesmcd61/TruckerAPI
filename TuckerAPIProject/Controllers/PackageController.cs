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

        [HttpPost]
        [Route("[controller]")]
        public void Post(PackageDto package)
        {
            this.dbContext.Set<PackageDto>().Add(package);
            this.dbContext.SaveChangesAsync();
        }

        [HttpPatch]
        [Route("[controller]")]
        public void Patch(PackageDto package)
        {
            this.dbContext.Set<PackageDto>().Update(package);
            this.dbContext.SaveChangesAsync();
        }
    }
}
