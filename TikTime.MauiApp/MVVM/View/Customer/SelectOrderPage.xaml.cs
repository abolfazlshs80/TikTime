using Mopups.Services;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.MVVM.Model.Enums;

namespace TikTime.MauiApp.MVVM.View.Customer;


public partial class SelectOrderPage : Mopups.Pages.PopupPage
{
    public SelectOrderPage()
    {
        InitializeComponent();
    }

    private async void ClosePopup(object sender, EventArgs e)
    {
      
    }

    private async void AddCustomerButton_OnClicked(object? sender, EventArgs e)
    {
        
    }

    private async void LastCustomerButton_OnClicked(object? sender, EventArgs e)
    {
        NavigationDataStore.Instance.Parameter = OrderCustomerType.Last;
        await Shell.Current.GoToAsync("..");
    }

    private async void OldButton_OnClicked(object? sender, EventArgs e)
    {
        NavigationDataStore.Instance.Parameter = OrderCustomerType.Old;
        await Shell.Current.GoToAsync("..");
    }
}