using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q1")]
public class q1Controller : ControllerBase

{
    /// <summary>
    /// This method will return a welcome message.
    /// </summary>
    /// <returns>welcome to 5125</returns>
    [HttpGet(template: "welcome")]
    public string welcome()
    {
        return "welcome to 5125!";
    }
}