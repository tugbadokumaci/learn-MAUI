using Microsoft.Extensions.Logging;

namespace PizzaMAUI;

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
        //builder.Services.AddSingleton<PizzaService>();
        //builder.Services.AddTransient<HomePage>();
        //builder.Services.AddTransient<HomeViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<MainPage>();
        AddPizzaServices(builder.Services);
        return builder.Build();
    }
    private static void AddPizzaServices(IServiceCollection services)
    {
        //services.AddSingletonWithShellRoute.
        services.AddSingleton<HomePage>();
        services.AddSingleton<HomeViewModel>();
        services.AddSingleton<PizzaService>();

        services.AddSingleton(provider => new HomeViewModel(provider.GetRequiredService<HomePage>()));
    }

}

