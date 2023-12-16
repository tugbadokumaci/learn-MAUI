using CommunityToolkit.Mvvm.ComponentModel;
using MauiTutorial.Models;

namespace MauiTutorial.Models.ViewModels;

internal partial class EmployeeDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Employee employee;
}