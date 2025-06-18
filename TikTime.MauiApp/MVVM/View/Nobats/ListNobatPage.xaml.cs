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
        model.LoadData(DateTime.Now.AddDays(-20));
        BindingContext = model;
      
    }

    private async void AddNobatTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        NavigationDataStore.Instance.Parameter = null;
        await Shell.Current.GoToAsync($"AddNobatPage");
    }

    bool isMenuVisible = false;

    //private async void ToggleMenu(object sender, EventArgs e)
    //{
    //    if (isMenuVisible)
    //    {
    //        // مخفی کردن منو
    //        await DropdownPanel.TranslateTo(0, -200, 300, Easing.CubicIn);
    //        DropdownPanel.IsVisible = false;
    //        isMenuVisible = false;
    //    }
    //    else
    //    {
    //        // نمایش منو
    //        await DropdownPanel.TranslateTo(0, 0, 300, Easing.CubicOut);
    //        DropdownPanel.IsVisible = true;
    //        isMenuVisible = true;
    //    }
    //}




    #region click

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void OnMenuClicked(object sender, EventArgs e)
    {
        DisplayAlert("Menu", "Menu clicked", "OK");
    }

    // Tab Handlers
    private async void OnSimpleTabClicked(object sender, EventArgs e)
    {
        SimpleButton.BackgroundColor = Colors.BlueViolet;
        AdvancedButton.BackgroundColor = Colors.White;

        AdvancedButton.TextColor = Colors.Black;
        SimpleButton.TextColor = Colors.White;

    }

    private async void OnAdvancedTabClicked(object sender, EventArgs e)
    {
        AdvancedButton.BackgroundColor = Colors.BlueViolet;
        SimpleButton.BackgroundColor = Colors.White;

        AdvancedButton.TextColor = Colors.White;
        SimpleButton.TextColor = Colors.Black;
    }

    // Top Action Handlers
    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("تنظیمات", "تنظیمات سیستم", "تایید");
    }

    private async void OnAtGlanceClicked(object sender, EventArgs e)
    {
        await DisplayAlert("در یک نگاه", "نمای کلی سیستم", "تایید");
    }

    private async void OnCalendarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("تقویم", "نمایش تقویم", "تایید");
    }

    private async void OnBookAppointmentClicked(object sender, EventArgs e)
    {
        await DisplayAlert("ثبت نوبت", "ثبت نوبت جدید", "تایید");
    }

    // Service Action Handlers
    private async void OnCustomerFileClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CustomerProfilePage");
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        bool result = await DisplayAlert("کنسل نوبت", "آیا مطمئن هستید که می‌خواهید این نوبت را کنسل کنید؟", "بله", "خیر");
        if (result)
        {
            await DisplayAlert("کنسل شد", "نوبت با موفقیت کنسل شد", "تایید");
        }
    }

    private async void OnSatisfactionClicked(object sender, EventArgs e)
    {
        await DisplayAlert("رضایت سنجی", "ارسال فرم رضایت سنجی", "تایید");
    }

    private async void OnEditAppointmentClicked(object sender, EventArgs e)
    {
        await DisplayAlert("ویرایش نوبت", "ویرایش اطلاعات نوبت", "تایید");
    }

    private async void OnContactCustomerClicked(object sender, EventArgs e)
    {
        await DisplayAlert("ارتباط با مشتری", "تماس با مشتری", "تایید");
    }

    // Bottom Navigation Handlers
    private void OnBottomSettingsClicked(object sender, EventArgs e)
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


    #endregion
}

