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

        // default constructor
        public MainViewModel()
        {
            ColorItems = new ObservableCollection<string>();
        }

        [RelayCommand] // addcolorcommand otomatik olark olluşturuldu. bunu butona eklemeliyiz.
        void AddColor() // color items içerisine color deerini ekler
        {
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

    }
}

