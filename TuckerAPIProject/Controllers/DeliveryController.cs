namespace TuckerAPIProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class DeliveryController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
            return;
        }
    }; 
}