﻿namespace TuckerAPIProject.Controllers
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNetCore.Mvc;



    using TuckerAPIProject.Data;
    using TuckerAPIProject.Dto;
    using TuckerAPIProject.Models;

    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;

        public AccountController(DbContext dbContext, IMapper mapper) 
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("[controller]/Auth")]
        public IActionResult PostAuth(AccountDto account)
        {
            var accountResult = this.dbContext.Account.Where(_ => _.UserName == account.UserName && _.Password == account.Password).FirstOrDefault();
            if (accountResult == null)
            {
                return this.BadRequest();
            }
            return this.Ok();
        }

        [HttpPost]
        [Route("[controller]")]
        public async Task<IActionResult> Post(AccountDto account)
        {
            var accountToSave = this.mapper.Map<AccountModel>(account);
            this.dbContext.Set<AccountModel>().Add(accountToSave);
            await this.dbContext.SaveChangesAsync();
            return this.Ok();
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
