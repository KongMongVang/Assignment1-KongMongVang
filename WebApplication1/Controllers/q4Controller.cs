using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q4")]
public class q4Controller : ControllerBase

{
    /// <summary>
    /// This method will return a knock knock joke.
    /// </summary>
    /// <returns>Who's there?</returns>
    /// <example>POST api/q4/knockknock</example>
    [HttpPost(template: "knockknock")]
    public string joke()
    {
        return "Who's there?";
    }
}