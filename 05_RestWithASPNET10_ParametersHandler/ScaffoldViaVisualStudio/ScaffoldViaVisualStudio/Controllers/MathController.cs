using Microsoft.AspNetCore.Mvc;
using ScaffoldViaVisualStudio.Services;
using ScaffoldViaVisualStudio.Utils;

namespace ScaffoldViaVisualStudio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly MathService _service;

        public MathController(MathService service)
        {
            _service = service;
        }


        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult sum(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = _service.Sum(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sum);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult subtraction(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var subtraction = _service.Subtraction(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(subtraction);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult multiplication(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = _service.Multiplication(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sum);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult division(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = _service.Division(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sum);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult mean(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = _service.mean(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sum);
            }

            return BadRequest("Invalid input!");

        }

        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber))
            {
                var sqrt = _service.SquareRoot(NumberHelper.ConvertToDecimal(firstNumber));
                return Ok(sqrt);
            }

            return BadRequest("Invalid input!");
        }

    }
}

