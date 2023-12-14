namespace PizzaMAUI.Pages
{
    public partial class HomePage : ContentPage
    {
        private readonly HomeViewModel _homeViewModel;
        public HomePage(HomeViewModel homeViewModel)
        {
            InitializeComponent();

            _homeViewModel = homeViewModel;
            this.BindingContext = _homeViewModel;
        }
    }
}