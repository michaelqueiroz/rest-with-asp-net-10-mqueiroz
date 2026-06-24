using Microsoft.AspNetCore.Mvc;

namespace ScaffoldViaVisualStudio.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class MathControllerV1 : ControllerBase
    {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum);
            }

            return BadRequest("Invalid input!");
            
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var subtraction = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(subtraction);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(sum);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult mean(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ((ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2);
                return Ok(sum);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var sqrt = Math.Sqrt((double) ConvertToDecimal(firstNumber));
                return Ok(sqrt);
            }

            return BadRequest("Invalid input!");

        }

        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if(decimal.TryParse(
                number,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }

        private bool IsNumeric(string number)
        {
            decimal decimalValue;
            bool IsNumber = decimal.TryParse(
                number, 
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue);
            return IsNumber;
        }
    }
}
