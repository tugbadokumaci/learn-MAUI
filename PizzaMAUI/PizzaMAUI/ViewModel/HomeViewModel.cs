

namespace PizzaMAUI.ViewModel
{
    public partial class HomeViewModel : ObservableObject
	{
		private readonly PizzaService _pizzaService;
        private HomePage homePage;

        public HomeViewModel(PizzaService pizzaService)
		{
			_pizzaService = pizzaService;
			Pizzas = new(_pizzaService.GetPopularPizzas());
		}

        public HomeViewModel(HomePage homePage)
        {
            this.homePage = homePage;
        }

        public ObservableCollection<Pizza> Pizzas { get; set; }

	}
}

