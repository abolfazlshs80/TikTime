using Mopups.Services;

namespace TikTime.MauiApp.MVVM.View.Customer;


public partial class SelectOrderPage : Mopups.Pages.PopupPage
{
    public SelectOrderPage()
    {
        InitializeComponent();
    }

    private async void ClosePopup(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAsync();
    }

    private async void AddCustomerButton_OnClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"AddCustomerPage");
    }
}