namespace TuckerAPIProject.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;

    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;

    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;

        public PackageController(DbContext dbContext, IMapper mapper) 
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]/{name}")]
        public PackageDto? Get(string name)
        {
            var package = this.dbContext.Package.Where(_ => _.Name == name).FirstOrDefault();
            return this.mapper.Map<PackageDto>(package);
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
