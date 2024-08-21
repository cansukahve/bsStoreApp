﻿using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore;
using System.Runtime.CompilerServices;

namespace WebAPI.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration)=>  services.AddDbContext<RepositoryContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
    }
