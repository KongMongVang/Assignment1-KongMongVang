using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q6")]
public class q6Controller : ControllerBase

{
    /// <summary>
    /// This method will return the area of a hexagon.
    /// </summary>
    /// <returns>returns area of hexagon</returns>
    /// <example>GET /api/q6/hexagon?side=1</example>
    /// <example>GET /api/q6/hexagon?side=1.5</example>
    /// <example>GET /api/q6/hexagon?side=20</example>
    [HttpGet(template: "hexagon")]
    public double AreaHexagon(double side)
    {
        return (3 * Math.Sqrt(3)) / 2 * Math.Pow(side, 2);
    }
}