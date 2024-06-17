using Microsoft.EntityFrameworkCore;

namespace IdentityService.Data
{
    public static class MigrationExtensions
    {
        public static void ApllyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope serviceScope = app.ApplicationServices.CreateScope();
            using ApplicationDbContext context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();
        }
    }
}
