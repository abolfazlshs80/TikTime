using MauiPersianToolkit.Controls;
using MauiPersianToolkit.Models;
using MauiPersianToolkit.Services.Dialog;
using System.Collections.ObjectModel;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.MVVM.Model.Enums;
using TikTime.MauiApp.MVVM.ViewModel.Customer;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.View.Customer;



public partial class ListCustomerPage : ContentPage
{
    private readonly ICustomerService _customerService;
    public ListCustomerPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this._customerService = serviceProvider.GetRequiredService<ICustomerService>();
        BindingContext = new ListCustomerViewModel(serviceProvider);


    }

    private async void AddCuctomerTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {

        await Shell.Current.GoToAsync($"AddCustomerPage");
    }



    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void OnMenuClicked(object sender, EventArgs e)
    {
        DisplayAlert("Menu", "Menu clicked", "OK");
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        await DisplayAlert("حذف", "حذف مشتری انتخاب شد", "تایید");
    }

    private async void OnSearchClicked(object sender, EventArgs e)
    {
        await DisplayAlert("جستجو", "جستجوی مشتری انتخاب شد", "تایید");
    }

    private async void OnSortClicked(object sender, EventArgs e)
    {
        await DisplayAlert("مرتب‌سازی", "مرتب‌سازی مشتریان انتخاب شد", "تایید");
    }

    private async void OnAddCustomerClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AddCustomerPage");
    }

    private void OnSettingsClicked(object sender, EventArgs e)
    {
        DisplayAlert("Settings", "Settings clicked", "OK");
    }


    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void CreateCustomerTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("AddCustomerPage");
    }

    private void OrderCustomerTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private async void OrderSelectCustomerTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("SelectOrderPage");
        await Task.WhenAll();



        if (NavigationDataStore.Instance.Parameter is OrderCustomerType type)
        {
            if (BindingContext is ListCustomerViewModel vm)
            {
                vm.OrderCustomer?.Execute(type);

                await DisplayAlert("jjs", "das", "a");
            }
        }


    }
}
