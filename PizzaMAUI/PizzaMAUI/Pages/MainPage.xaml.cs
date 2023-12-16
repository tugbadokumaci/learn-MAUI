namespace PizzaMAUI.Pages; // klasprden klasore tasıdıktan sonra namespace güncelliyorum + xaml dosyasını da 

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        //BindingContext = new MainViewModel();

    }
    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        Navigation.PushAsync(new HomePage());
        //await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        //await Shell.Current.GoToAsync($"//HomePage");

        //await Shell.Current.GoToAsync("//HomePage");
        //await Shell.Current.GoToAsync(nameof(HomePage));
    }
}


