using Maui.GoogleMaps.Hosting;
using Microsoft.Extensions.Logging;

namespace eKsiondz;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
#if ANDROID
			.UseGoogleMaps()
#elif IOS
			.UseGoogleMaps("AIzaSyDrnaAW5Wugrf4jsAtUm99dfsGmpM0KcF4")
#endif			
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
