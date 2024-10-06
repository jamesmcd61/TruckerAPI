namespace TuckerAPIProject.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;

    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;
    using TuckerAPIProject.Models;

    [ApiController]
    public class TruckerInfoController : ControllerBase
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;

        public TruckerInfoController(DbContext dbContext, IMapper mapper) 
        { 
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]/{name}")]
        public TruckerInfoDto? Get(string name)
        {
            var truckerInfo = this.dbContext.TruckerInfo.Where(_ => _.Name == name).FirstOrDefault();
            return this.mapper.Map<TruckerInfoDto>(truckerInfo);
        }

        [HttpPost]
        [Route("[controller]")]
        public async Task<IActionResult> Post(TruckerInfoDto truckerInfo)
        {
            var trickerInfoToSave = this.mapper.Map<TruckerInfoModel>(truckerInfo);
            this.dbContext.Set<TruckerInfoModel>().Add(trickerInfoToSave);
            await this.dbContext.SaveChangesAsync();
            return this.Ok();
        }

        [HttpPatch]
        [Route("[controller]")]
        public void Patch(TruckerInfoDto truckerInfo)
        {
            this.dbContext.Set<TruckerInfoDto>().Update(truckerInfo);
            this.dbContext.SaveChangesAsync();
        }
    }
}
