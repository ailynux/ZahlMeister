// File: PayMon/Repositories/PaymentRepository.cs

using Dapper;
using Microsoft.Data.SqlClient; // Correct namespace for SqlConnection
using Microsoft.Extensions.Logging; // For logging
using System.Data;
using PayMon.Models; // Ensure this is at the top to use the Payment model

namespace PayMon.Repositories
{
    public class PaymentRepository
    {
        private readonly string _connectionString;
        private readonly ILogger<PaymentRepository> _logger; // Add logger

        public PaymentRepository(IConfiguration configuration, ILogger<PaymentRepository> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new ArgumentNullException(nameof(configuration));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Payment> GetPayments()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    _logger.LogInformation("Attempting to fetch payments from database.");
                    string query = "SELECT * FROM Payments";
                    var payments = db.Query<Payment>(query);
                    _logger.LogInformation($"Successfully retrieved {payments.Count()} payments.");
                    return payments;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetPayments: {ex}");
                throw;
            }
        }


        public void UpdatePaymentStatus(int paymentId, string status)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE Payments SET PaymentStatus = @Status WHERE PaymentId = @Id";
                    db.Execute(query, new { Status = status, Id = paymentId });
                }
            }
            catch (SqlException ex)
            {
                // Log SQL-specific errors
                _logger.LogError($"SQL error while updating payment status: {ex.Message}");
                throw; // Re-throw the exception to handle it in a higher layer
            }
            catch (Exception ex)
            {
                // Log general errors
                _logger.LogError($"Error updating payment status: {ex.Message}");
                throw;
            }
        }
    }
}
