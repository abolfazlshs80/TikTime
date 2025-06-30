using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.MVVM.View.Account;
using TikTime.MauiApp.MVVM.View.Customer;
using TikTime.MauiApp.MVVM.View.Main;
using TikTime.MauiApp.MVVM.View.Nobats;
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
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<INobatService, NobatService>();
            services.AddScoped<INottificationService, NottificationService>();
          
            services.AddSingleton<NavigationDataStore>();


            return services;
        }
        public static IServiceCollection ConfigurePage(this IServiceCollection services)
        {

      
            services.AddTransient<LoginNumberPage>();
            services.AddTransient<LoginPasswordPage>();
            services.AddTransient<MainPage>();
            services.AddTransient<AddCustomerDialog>();
            services.AddTransient<AddCustomerPage>();
            services.AddTransient<AddPage>();
            services.AddTransient<SettingPage>();
            services.AddTransient<ListCustomerPage>();
            services.AddTransient<EditCustomerPage>();
            services.AddTransient<AddNobatPage>();
            services.AddTransient<ListNobatPage>();
            services.AddTransient<SearchCustomerPage>();
            services.AddTransient<NotificationPage>();
            // Add other services as needed
            return services;
        }
        public static IServiceCollection RepConfigure(this IServiceCollection services)
        {
          //  services.AddScoped<INottificationRepository, NottificationRepository>();
            return services;
        }
        public static IServiceCollection SqlConfigure(this IServiceCollection services)
        {

            services.AddSingleton(new SQLiteAsyncConnection(
                Path.Combine(FileSystem.AppDataDirectory, "database.db3")));
            return services;
        }
    }
}
