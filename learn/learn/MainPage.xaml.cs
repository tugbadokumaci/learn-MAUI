﻿using learn.ViewModel;

namespace learn;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage(MainViewModel mvm)
	{
		InitializeComponent();
        this.BindingContext = mvm; 
	}

	/*
	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	*/
}


