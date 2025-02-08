using Microsoft.Extensions.Logging;
using Maui.GoogleMaps;
using Maui.GoogleMaps.Hosting;

namespace eParafiia;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
#if ANDROID
            .UseGoogleMaps()
#elif IOS
            .UseGoogleMaps("AIzaSyDrnaAW5Wugrf4jsAtUm99dfsGmpM0KcF4")
#endif
            .UseMauiApp<App>()
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