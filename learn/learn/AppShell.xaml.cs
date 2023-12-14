namespace learn;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
		Routing.RegisterRoute(nameof(ResourcePage), typeof(ResourcePage));
    }
}

