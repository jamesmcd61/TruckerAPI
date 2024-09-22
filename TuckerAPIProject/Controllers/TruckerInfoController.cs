namespace TuckerAPIProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class TruckerInfoController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
            return;
        }
    }
}
