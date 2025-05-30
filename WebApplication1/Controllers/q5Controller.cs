using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q5")]
public class q5Controller : ControllerBase

{
    /// <summary>
    /// This method will return a secret integer.
    /// </summary>
    /// <returns>5</returns>
    /// <returns>-200</returns>
    /// <example>POST api/q5/secret 5</example>
    /// <example>POST api/q5/secret -200</example>
    [HttpPost(template: "secret")]
    public string secretMessage([FromBody]int secretNum)
    {
        return "Shh.. the secret is " + secretNum;
    }
}