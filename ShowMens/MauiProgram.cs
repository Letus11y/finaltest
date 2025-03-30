using Microsoft.Extensions.Logging;
using ShowMens.Pages;
using ShowMens.ViewModels;

namespace ShowMens;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
			
        builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<OtherPage>();
		builder.Services.AddSingleton<OtherPageViewModel>();
		
        

		return builder.Build();
	}
}
