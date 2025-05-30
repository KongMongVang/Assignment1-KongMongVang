using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q3")]
public class q3Controller : ControllerBase

{
    /// <summary>
    /// This method will return a cube integer.
    /// </summary>
    /// <returns>64</returns>
    /// <returns>-64</returns>
    /// <returns>1000</returns>
    [HttpGet(template: "cube/{num1}")]
    public int cube (int num1)
    {
        int cubeValue = num1 * num1 * num1;
        return cubeValue;
    }
}