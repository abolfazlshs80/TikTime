using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using TikTime.MauiApp.Tools.Static.ExtentionMethod;

namespace TikTime.MauiApp
{
    public static class MauiProgram
    {
        public static Microsoft.Maui.Hosting.MauiApp CreateMauiApp()
        {
            var builder = Microsoft.Maui.Hosting.MauiApp.CreateBuilder(); // Use the correct namespace for CreateBuilder  

            builder.Services

                .ConfigureServices()
                .ConfigurePage();

            builder
                .UseMauiApp<App>()
                .ConfigureMopups() // <<== Add this line

                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
