namespace TuckerAPIProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;



    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;

    [ApiController]
    public class AccountController : ControllerBase
    {
        private DbContext dbContext;

        public AccountController(DbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("[controller]/{userName}/{password}")]
        public AccountDto? Get(string userName, string password)
        {
            return this.dbContext.Account.Where(_ => _.UserName == userName && _.Password == password).FirstOrDefault();
        }

        [HttpPost]
        [Route("[controller]")]
        public void Post(AccountDto account)
        {
            this.dbContext.ProjectTo
            this.dbContext.Set<AccountDto>().Add(account);
            this.dbContext.SaveChangesAsync();
        }

        [HttpPatch]
        [Route("[controller]")]
        public void Patch(AccountDto account)
        {
            this.dbContext.Set<AccountDto>().Update(account);
            this.dbContext.SaveChangesAsync();
        }
    }
}
