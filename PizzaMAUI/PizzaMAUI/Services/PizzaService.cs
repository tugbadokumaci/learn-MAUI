﻿using PizzaMAUI.Models;

namespace PizzaMAUI.Services
{
	public class PizzaService
	{
        private readonly static IEnumerable<Pizza> _pizzas = new List<Pizza>
        {
            new Pizza
            {
                Name = "Pizza 1",
                Image = "pizza1.png",
                Price = 1.45
            },
            new Pizza
            {
                Name = "Pizza 2",
                Image = "pizza2.png",
                Price = 2.45
            },
            new Pizza
            {
                Name = "Pizza 3",
                Image = "pizza3.png",
                Price = 4.34
            },
            new Pizza
            {
                Name = "Pizza 4",
                Image = "pizza4.png",
                Price = 3.5
            },
            new Pizza
            {
                Name = "Pizza 5",
                Image = "pizza5.png",
                Price = 7.45
            },
            new Pizza
            {
                Name = "Pizza 6",
                Image = "pizza6.png",
                Price = 1.5
            },
            new Pizza
            {
                Name = "Pizza 7",
                Image = "pizza7.png",
                Price = 6.5
            },
            new Pizza
            {
                Name = "Pizza 8",
                Image = "pizza8.png",
                Price = 7.77
            }
        };
        public IEnumerable<Pizza> GetAllPizzas() => _pizzas;
        public IEnumerable<Pizza> GetPopularPizzas(int count =6) => _pizzas.OrderBy(p=> Guid.NewGuid()).Take(count);
        public IEnumerable<Pizza> GetPizzas(string searchTerm) => string.IsNullOrWhiteSpace(searchTerm) ? _pizzas : _pizzas.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));

    }
}

