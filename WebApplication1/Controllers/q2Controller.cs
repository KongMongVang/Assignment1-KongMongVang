using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q2")]
public class q2Controller : ControllerBase

{
    /// <summary>
    /// This method will return a greeting
    /// </summary>
    /// <returns>Hi Gary!</returns>
    /// /// <returns>Hi Renée!</returns>
    [HttpGet(template: "greeting")]
    public string greeting(string name)
    {
        string response = "Hi " + name + "!";
        return response;
    }
}