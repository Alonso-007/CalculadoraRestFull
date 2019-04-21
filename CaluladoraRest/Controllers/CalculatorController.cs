using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CaluladoraRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private int ConvertToDecimal(string number)
        {
            throw new NotImplementedException();
        }

        private bool IsNumeric(string number)
        {

        }
    }
}