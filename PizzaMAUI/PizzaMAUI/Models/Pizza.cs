using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PizzaMAUI.Models
{
	public partial class Pizza : ObservableObject
	{
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        private int _cartQuantity;

        public double Amount => CartQuantity * Price;

        // observable property cart quantitity modify edecek, ve ne zaman cart quantity değişiyorsa Amount'da haberdae et.
        // Amount tekrar hesaplnamalı

        public Pizza Clone() => MemberwiseClone() as Pizza;
    }
	
}

