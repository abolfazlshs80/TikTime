using System.Collections.ObjectModel;

namespace TikTime.MauiApp.MVVM.View.Main;



public partial class NotificationPage : ContentPage
{
    public ObservableCollection<Notification> Notifications { get; set; }

    public NotificationPage()
    {
        InitializeComponent();
        LoadNotifications();
    }

    private void LoadNotifications()
    {
        Notifications = new ObservableCollection<Notification>
        {
            new Notification
            {
                Title = "سیستم",
                Message = "ورود جدید به حساب کاربری",
                DeviceInfo = "Chrome :اطلاعات دستگاه",
                TimeAgo = "۲ هفته پیش"
            },
            new Notification
            {
                Title = "سیستم",
                Message = "ورود جدید به حساب کاربری",
                DeviceInfo = "iPhone :اطلاعات دستگاه",
                TimeAgo = "۴ هفته پیش"
            }
        };
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
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

public class Notification
{
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string DeviceInfo { get; set; } = string.Empty;
    public string TimeAgo { get; set; } = string.Empty;
}