namespace TuckerAPIProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class PackageController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
            return;
        }
    }
}
