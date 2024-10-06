using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PayMon.Repositories;

namespace PayMon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentRepository _repository;
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(PaymentRepository repository, ILogger<PaymentController> logger)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult GetPayments()
        {
            try
            {
                var payments = _repository.GetPayments();
                return Ok(payments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving payments.");
                return StatusCode(500, "An error occurred while retrieving payments.");
            }
        }

        [HttpPost("{id}/status")]
        public IActionResult UpdatePaymentStatus(int id, [FromBody] string status)
        {
            try
            {
                _repository.UpdatePaymentStatus(id, status);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while updating payment status for payment ID {id}.");
                return StatusCode(500, "An error occurred while updating payment status.");
            }
        }

        // Handle preflight CORS requests
        [HttpOptions]
        public IActionResult Options()
        {
            Response.Headers.Append("Access-Control-Allow-Origin", "http://localhost:3000"); // Use Append instead of Add
            Response.Headers.Append("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
            Response.Headers.Append("Access-Control-Allow-Headers", "Content-Type, Authorization");
            return Ok();
        }

            }
}
