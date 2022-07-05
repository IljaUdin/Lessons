using Cinema.DB;
using Microsoft.EntityFrameworkCore;

namespace Cinema.API
{
    public static class StartupExtension
    {
        public static void ConfigureDbConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
