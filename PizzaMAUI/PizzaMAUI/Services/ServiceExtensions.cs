// ServiceExtensions.cs

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace YourNamespace
{
    public static class ServiceExtensions
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();

            // Transient objects lifetime services are created each time they are requested.
            // This lifetime works best for lightweight, stateless services.
            foreach (var type in currentAssembly.DefinedTypes.Where(e => e.IsSubclassOf(typeof(Page)) || e.IsSubclassOf(typeof(HomeViewModel))))
            {
                builder.Services.AddTransient(type.AsType());
            }
            return builder;
        }
    }
}
