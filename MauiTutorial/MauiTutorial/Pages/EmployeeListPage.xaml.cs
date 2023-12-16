﻿using MauiTutorial.Models;
using MauiTutorial.Models.ViewModels;

namespace MauiTutorial.Pages;

public partial class EmployeeListPage : ContentPage
{
    public EmployeeListPage()
    {
        InitializeComponent();

        BindingContext = new EmployeesViewModel();
    }

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var employee = (Employee)e.Item;
        var employeeDetailViewModel = new EmployeeDetailViewModel { Employee = employee };
        var employeeDetailPage = new EmployeeDetailPage();
        employeeDetailPage.BindingContext = employeeDetailViewModel;

        Navigation.PushAsync(employeeDetailPage);
    }
}