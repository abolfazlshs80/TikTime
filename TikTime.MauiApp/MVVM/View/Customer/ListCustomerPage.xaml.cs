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
}