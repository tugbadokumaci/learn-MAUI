using learn.ViewModel;
using Microsoft.Extensions.Logging;

namespace learn;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<MainPage>(); //çoğunlukla singleton olarka dependency injection ile mainviewmodel, mainpage
        builder.Services.AddSingleton<MainViewModel>();
        return builder.Build();
	}
}

