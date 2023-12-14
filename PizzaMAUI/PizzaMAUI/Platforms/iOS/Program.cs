

using PizzaMAUI.Pages;
using PizzaMAUI.Services;
using PizzaMAUI.ViewModel;
using Microsoft.Extensions.Logging;
using UIKit;

namespace PizzaMAUI;

public class Program
{
	// This is the main entry point of the application.
	static void Main(string[] args)
	{
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
        UIApplication.Main(args, null, typeof(AppDelegate));
	}

}

