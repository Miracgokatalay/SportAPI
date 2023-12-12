using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportAPI.Application.Repositories;
using SportAPI.Persistance.Contexts;
using SportAPI.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {//scoped da her request için oluşturulan nesne iş bittikten sonra imha/despose edilir
            services.AddDbContext<SportAPIDbContext>(options=> options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICategoryReadRepository,CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository,CategoryWriteRepository>();
            services.AddScoped<ILectureReadRepository,LectureReadRepository>();
            services.AddScoped<ILectureWriteRepsitory, LectureWriteRepository>();
            services.AddScoped<IUserReadRepository,UserReadRepository>();
            services.AddScoped<IUserWriteRepository,UserWriteRepository>();
            services.AddScoped<ILectureUserReadRepository,LectureUserReadRepository>();
            services.AddScoped<ILectureUserWriteRepository,LectureUserWriteRepository>();
        }
    }
}
