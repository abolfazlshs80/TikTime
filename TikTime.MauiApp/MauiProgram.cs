using CommunityToolkit.Maui;
using MauiPersianToolkit;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;
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
                .ConfigurePage()
                .SqlConfigure()
                .RepConfigure()
                ;

            builder
                .UseMauiApp<App>()
                .ConfigureMopups() // <<== Add this line

                //calender persian
                .UseMauiCommunityToolkit()
                .UsePersianUIControls()

                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
#if ANDROID
            PickerHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
                handler.PlatformView.BackgroundTintList =
                    Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
            });
#endif
            return builder.Build();
        }
    }
}
