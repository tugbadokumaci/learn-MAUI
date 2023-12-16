
using PizzaMAUI.ViewModel;

namespace PizzaMAUI.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel(new PizzaService());
        }
    }
}