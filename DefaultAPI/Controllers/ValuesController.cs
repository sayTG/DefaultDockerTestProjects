using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DefaultAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Get")]
        public IActionResult Get()
        {
            return Ok(JsonConvert.SerializeObject(new { result = "This is from the API" }));
        }
    }
}
