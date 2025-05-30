using System.Globalization;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/q8")]
public class q8Controller : ControllerBase

{
    /// <summary>
    /// This method will return a checkout summary.
    /// </summary>
    /// <returns>returns the total of the order with tax.</returns>
    /// <example>POST api/q8/squashfellows Small=1&Large=1</example>
    /// <example>POST api/q8/squashfellows Small=2&Large=1</example>
    /// <example>POST api/q8/squashfellows Small=100&Large=100</example>
    [HttpPost(template: "squashfellows")]
    public string checkout([FromForm] int Small, [FromForm] int Large)
    {
        double smallTotal = Small * 25.50;
        double largeTotal = Large * 40.50;
        double subTotal = smallTotal + largeTotal;
        double tax = 0.13 * subTotal;
        double total = tax + subTotal;
        return $"{Small} Small @25.50 = ${smallTotal.ToString("F", CultureInfo.InvariantCulture)}; {Large} large @40.50 = ${largeTotal.ToString("F", CultureInfo.InvariantCulture)}; subtotal = ${subTotal.ToString("F", CultureInfo.InvariantCulture)}; tax = ${tax.ToString("F", CultureInfo.InvariantCulture)} HST; total = ${total.ToString("F", CultureInfo.InvariantCulture)}";
    }
}