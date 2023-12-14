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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<MainPage>(); 
        AddPizzaServices(builder.Services);
		return builder.Build();
    }
    private static void AddPizzaServices(IServiceCollection services)
    {
        services.AddSingleton<PizzaService>();

        // Registering HomePage and HomeViewModel as singleton services
        services.AddSingleton<HomePage>();
        services.AddSingleton<HomeViewModel>();

        // Optionally, if you want to associate HomePage with HomeViewModel, you can use AddSingleton with a factory
        services.AddSingleton(provider => new HomeViewModel(provider.GetRequiredService<HomePage>()));

        // Other services registration...

        // Return type can be void since you are modifying the services collection directly
    }

}

