using TikTime.MauiApp.MVVM.ViewModel.Customer;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.View.Customer;

public partial class SearchCustomerPage : ContentPage
{
	

    private readonly ICustomerService _customerService;
    public SearchCustomerPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this._customerService = serviceProvider.GetRequiredService<ICustomerService>();
        BindingContext = new ListCustomerViewModel(serviceProvider);


    }

    private void SearchBarNameCustomer_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (BindingContext is ListCustomerViewModel vm)
        {
            vm.SearchBarNameCustomer_OnTextChanged?.Execute(e.NewTextValue);
        }
    }

    private void SearchBarNameCustomer_OnSearchButtonPressed(object? sender, EventArgs e)
    {
        if (BindingContext is ListCustomerViewModel vm)
        {
            vm.SearchBarNameCustomer_OnTextChanged?.Execute(SearchBarNameCustomer.Text);
        }
    }
}