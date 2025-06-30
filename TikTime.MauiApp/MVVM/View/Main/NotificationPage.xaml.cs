using System.Collections.ObjectModel;
using TikTime.MauiApp.MVVM.ViewModel.Nottifications;

namespace TikTime.MauiApp.MVVM.View.Main;



public partial class NotificationPage : ContentPage
{
   
    public NotificationPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        BindingContext = new ListNottificationViewModel(serviceProvider);
    
    }


    private async void OnBackClicked(object sender, EventArgs e)
    {
        //string phoneNumber = "989123456789"; // شماره بدون ۰ و با کد کشور
        //string message = Uri.EscapeDataString("سلام، این پیام تستی است");
        //string url = $"https://wa.me/{phoneNumber}?text={message}";

        //await Launcher.Default.OpenAsync(url);

        await Shell.Current.GoToAsync("..");
    }

    private void OnMenuClicked(object sender, EventArgs e)
    {
        DisplayAlert("Menu", "Menu clicked", "OK");
    }

    private async void OnSatisfactionSurveyClicked(object sender, EventArgs e)
    {
        await DisplayAlert("رضایت‌سنجی", "رضایت‌سنجی انتخاب شد", "تایید");
    }

    private async void OnOnlineReservationClicked(object sender, EventArgs e)
    {
        await DisplayAlert("رزرو آنلاین", "رزرو آنلاین انتخاب شد", "تایید");
    }

    private async void OnAllNotificationsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("همه اعلانات", "همه اعلانات انتخاب شد", "تایید");
    }

    private void OnSettingsClicked(object sender, EventArgs e)
    {
        DisplayAlert("Settings", "Settings clicked", "OK");
    }

    private void OnListClicked(object sender, EventArgs e)
    {
        DisplayAlert("List", "List clicked", "OK");
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        DisplayAlert("Add", "Add clicked", "OK");
    }

    private void OnSearchClicked(object sender, EventArgs e)
    {
        DisplayAlert("Search", "Search clicked", "OK");
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}
