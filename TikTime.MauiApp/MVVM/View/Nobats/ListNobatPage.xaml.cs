using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.MVVM.ViewModel.Nobat;

namespace TikTime.MauiApp.MVVM.View.Nobats;

public partial class ListNobatPage : ContentPage
{
    public ListNobatPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        // Initialize sample data
      
        var model = new ListNobatViewModel(serviceProvider);
        model.LoadData(DateTime.Now);
        BindingContext = model;
      
    }

    private async void OnAddAppointmentClicked(object sender, EventArgs e)
    {
        await DisplayAlert("ثبت نوبت", "Add appointment functionality", "OK");
    }

    private async void OnTimeSlotClicked(object sender, EventArgs e)
    {
        await DisplayAlert("انتخاب زمان", "Time slot selection", "OK");
    }

    private async void AddNobatTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        NavigationDataStore.Instance.Parameter = null;
        await Shell.Current.GoToAsync($"AddNobatPage");
    }
}

