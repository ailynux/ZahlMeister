using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PayMon.Repositories; // Add this to resolve PaymentRepository

namespace PayMon
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure CORS to allow requests from the frontend
            services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", builder =>
                {
                    builder.WithOrigins("http://localhost:3000") // Allow requests from your React app
                           .AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowCredentials(); // Use if you are sending credentials
                });
            });

            services.AddControllers(); // Add support for controllers

            // Register PaymentRepository
            services.AddScoped<PaymentRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Show detailed error pages in development
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
            app.UseRouting(); // Enable routing

            app.UseCors("AllowFrontend"); // Apply CORS policy

            app.UseAuthorization(); // Enable authorization

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Map API controllers
            });
        }
    }
}
