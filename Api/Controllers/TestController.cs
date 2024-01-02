using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPITest.Controllers; 

[ApiController]
[Route("[controller]")]
[Consumes("application/json")]
[Produces("application/json")]
public class TestController : ControllerBase {

    [HttpGet("Test1")]
    public IActionResult GetTest1() {
        return Ok("Test1");
    }

    [HttpGet("Test2")]
    public IActionResult GetTest2() {
        return Ok("Test2");
    }

    [HttpGet("Test3")]
    public IActionResult GetTest3() {
        return Ok("Test3");
    }

}