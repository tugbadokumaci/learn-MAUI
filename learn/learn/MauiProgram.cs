using learn.ViewModel;
using Microsoft.Extensions.Logging;
using ZXing.Net.Maui.Controls;
namespace learn;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseBarcodeReader()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
		builder.Services.AddSingleton<MainPage>(); //çoğunlukla singleton olarka dependency injection ile mainviewmodel, mainpage
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddTransient<DetailPage>(); 
        builder.Services.AddTransient<DetailViewModel>();

        return builder.Build();
	}
}


/*
 *  singleton is like a global, create one copy of it and keep that in memory, 
 *  transient created and destroyed evertime
 */