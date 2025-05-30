using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q6")]
public class q6Controller : ControllerBase

{
    /// <summary>
    /// This method will return a secret integer.
    /// </summary>
    /// <returns>5</returns>
    /// <returns>-200</returns>
    [HttpPost(template: "hexagon")]
    public decimal AreaHexagon(decimal side)
    {
        
        return 
    }
}