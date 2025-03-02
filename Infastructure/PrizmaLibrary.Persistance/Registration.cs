using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrizmaLibrary.Application.Interfaces.Repositories;
using PrizmaLibrary.Application.Interfaces.UnitOfWorks;
using PrizmaLibrary.Persistance.Context;
using PrizmaLibrary.Persistance.Repositories;
using PrizmaLibrary.Persistance.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Persistance
{
    public static class Registration
    {
        public static void AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AddDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                /*bitirdikten sonra mysql'e geçiş yapacağım
                DB'yi MsSQL üzerinden daha rahat kontrol edebildiğim için SqlServer kullandım*/
            });

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
