using MauiTutorial.Pages;

namespace MauiTutorial;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new EmployeeListPage());
    }
}