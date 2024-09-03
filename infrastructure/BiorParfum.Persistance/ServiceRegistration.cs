using BiorParfum.Persistance.EntityFrameworks;
using BiorParfum.Persistance.Interceptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BiorParfum.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("local");
            services
                .AddDbContext<BiorParfumContext>(options => options
                .UseSqlServer(connectionString)
                .AddInterceptors(new UpdateBaseEntityInterceptor()));

            services.AddHttpContextAccessor();
           
                  
        }
    }
}
