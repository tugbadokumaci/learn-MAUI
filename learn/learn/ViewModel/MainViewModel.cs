using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace learn.ViewModel
{
    /* BEFORE COMMUNİTY TOOLKİT MVVM    
	public class MainViewModel : INotifyPropertyChanged
	{
        string color;
        public string Color
        {
            get => color;
            set
            {
                color = value;
                OnPropertyChanged(color);
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
    */

    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] // dependincy/analayser/source generator  OTOMATİK NOTİİFİCATİON EVENT üretir.
        string color;

        [ObservableProperty]
        ObservableCollection<string> colorItems;

        IConnectivity connectivity;

        // default constructor
        public MainViewModel(IConnectivity connectivity)
        {
            ColorItems = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }

        [RelayCommand] // addcolorcommand otomatik olark olluşturuldu. bunu butona eklemeliyiz.
        async Task AddColor() // color items içerisine color deerini ekler
        {
            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Hata", "Internet bağlantınız yok", "tamam");
            }
            ColorItems.Add(Color);
            Color = String.Empty;
        }

        [RelayCommand]
        void DeleteColor(string colorName)
        {
            if (ColorItems.Contains(colorName))
            {
                ColorItems.Remove(colorName);
            }
        }

        [RelayCommand] // RelayCommand instead of ICommand
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync(nameof(DetailPage)); // nameof(DetailPage)
        }

        [RelayCommand] 
        async Task TapResource(string s)
        {
            await Shell.Current.GoToAsync(nameof(ResourcePage)); // nameof(DetailPage)
        }

        [RelayCommand]
        async Task Navigate() => Shell.Current.GoToAsync(nameof(DetailPage));
    }
}

