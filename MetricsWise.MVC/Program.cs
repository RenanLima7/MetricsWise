using MetricsWise.Infra.IoC;

namespace MetricsWise.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            try
            {
                Console.WriteLine("Starting Web Builder!");

                var builder = WebApplication.CreateBuilder(args);

                AddServices(builder);

                Console.WriteLine("Starting MetricsWise!");

                var app = builder.Build();

                AddAppConfiguration(app);

                app.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catastrophic Error!" + ex);
                throw;
            }
            finally
            {
                Console.WriteLine($"Server Is Enable in - {environment}");
            }
        }

        private static void AddServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            builder.Services.AddEntityFramework(builder.Configuration);

            builder.Services.AddRazorPages();

            //builder.Services.AddDependencyInjectionConfiguration();

            //builder.Services.AddJwtTConfiguration(builder.Configuration);

            //builder.Services.AddFluentValidationConfiguration();

            //builder.Services.AddEndpointsApiExplorer();

            //builder.Services.AddSwaggerConfiguration();

            //builder.Services.AddAutoMapperConfiguration();

            //builder.Services.AddCors();
        }

        private static void AddAppConfiguration(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseEntityFramework();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapRazorPages();

            //app.UseJwtConfiguration();

            //app.MapControllers();

            //app.UseCors();

            //app.UseSwaggerConfiguration();
        }
    }
}