using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.View.Account;
using TikTime.MauiApp.MVVM.View.Main;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.Tools.Static.ExtentionMethod
{
   public static class InjectServiceExtention
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            
            // Register your services here
            services.AddSingleton<FakeDataService>();
            services.AddScoped<IUserService, UserService>();

            services.AddTransient<LoginNumberPage>();
            services.AddTransient<LoginPasswordPage>();
            services.AddTransient<MainPage>();
            // Add other services as needed
            return services;
        }
    }
}
