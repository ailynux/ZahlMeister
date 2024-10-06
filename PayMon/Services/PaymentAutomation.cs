// // File: PayMon/Services/PaymentAutomation.cs

// using OpenQA.Selenium;
// using OpenQA.Selenium.Chrome;
// using System;

// namespace PayMon.Services
// {
//     public class PaymentAutomation : IDisposable
//     {
//         private readonly IWebDriver _driver;
//         private readonly string _paymentUrl = "https://payment-system-url.com";
//         private readonly string _checkStatusUrl = "https://payment-system-url.com/check-status";

//         public PaymentAutomation()
//         {
//             // Initialize the ChromeDriver and configure options
//             var options = new ChromeOptions();
//             options.AddArgument("--headless"); // Run in headless mode if needed
//             _driver = new ChromeDriver(options);
//         }

//         public void LoginToPaymentSystem(string username, string password)
//         {
//             try
//             {
//                 _driver.Navigate().GoToUrl(_paymentUrl);
                
//                 var usernameField = _driver.FindElement(By.Id("username"));
//                 var passwordField = _driver.FindElement(By.Id("password"));
//                 var loginButton = _driver.FindElement(By.Id("login-button"));

//                 usernameField.SendKeys(username);
//                 passwordField.SendKeys(password);
//                 loginButton.Click();

//                 // Optionally, wait for the login to complete or check for success
//             }
//             catch (NoSuchElementException ex)
//             {
//                 // Log or handle the exception appropriately
//                 Console.WriteLine($"Error during login: {ex.Message}");
//             }
//         }

//         public string CheckPaymentStatus(string transactionId)
//         {
//             try
//             {
//                 _driver.Navigate().GoToUrl(_checkStatusUrl);

//                 var transactionField = _driver.FindElement(By.Id("transaction-id"));
//                 var submitButton = _driver.FindElement(By.Id("submit-button"));

//                 transactionField.SendKeys(transactionId);
//                 submitButton.Click();

//                 // Fetch the payment status
//                 var statusElement = _driver.FindElement(By.Id("status"));
//                 return statusElement.Text; // Return the status of the payment
//             }
//             catch (NoSuchElementException ex)
//             {
//                 // Log or handle the exception appropriately
//                 Console.WriteLine($"Error checking payment status: {ex.Message}");
//                 return "Error: Unable to fetch status";
//             }
//         }

//         public void Dispose()
//         {
//             // Close the browser and clean up resources
//             _driver?.Quit();
//         }
//     }
// }
