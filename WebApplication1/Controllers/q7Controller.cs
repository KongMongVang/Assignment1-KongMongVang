using System.Globalization;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q7")]
public class q7Controller : ControllerBase

{
    /// <summary>
    /// This method will return a string of the current date.
    /// </summary>
    /// <returns>current date adjusted by given day.</returns>
    /// <example>GET /api/q7/timemachine?days=1</example>
    /// <example>GET /api/q7/timemachine?days=-1</example>
    [HttpGet(template: "timemachine")]
    public string dateCalculator(int days)
    {
        DateTime today = DateTime.Today.AddDays(days);
        return today.ToString("yyyy-MM-dd");
    }
}