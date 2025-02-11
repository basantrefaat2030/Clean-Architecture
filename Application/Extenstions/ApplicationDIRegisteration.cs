using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extenstions
{
    public static class ApplicationDIRegisteration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            //add our dependancies here 
            return services;
        }
    }
}
