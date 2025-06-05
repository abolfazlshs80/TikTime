using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.View.Account;
[QueryProperty(nameof(PhoneNumber), "phone")]
public partial class LoginPasswordPage : ContentPage
{
    public string PhoneNumber { get; set; }
    private readonly IUserService _userService;
    public LoginPasswordPage(IUserService userService)
    {
        InitializeComponent();
        this._userService = userService;

    }

    private void OnDigitChanged(object sender, TextChangedEventArgs e)
    {
        var entry = sender as Entry;

        if (string.IsNullOrEmpty(entry.Text))
            return;

        // فقط اگر یک رقم بود و عدد بود، ادامه بده
        if (entry.Text.Length == 1 && char.IsDigit(entry.Text[0]))
        {
            MoveToNextEntry(entry);
        }
        else
        {
            // اگر بیشتر از یک حرف تایپ شد یا غیر عددی بود، پاک کن
            entry.Text = "";
        }
    }

    private void MoveToNextEntry(Entry currentEntry)
    {
        if (currentEntry == Digit1)
            Digit2.Focus();
        else if (currentEntry == Digit2)
            Digit3.Focus();
        else if (currentEntry == Digit3)
            Digit4.Focus();
        else if (currentEntry == Digit4)
            Digit5.Focus();
        else if (currentEntry == Digit5)
            Digit6.Focus();
        else if (currentEntry == Digit4)
            currentEntry.Unfocus(); // آخرین ورودی
    }

    private async void ButtonLogin_OnClicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Digit1.Text) | string.IsNullOrEmpty(Digit2.Text) |
           string.IsNullOrEmpty(Digit3.Text) | string.IsNullOrEmpty(Digit4.Text) |
           string.IsNullOrEmpty(Digit5.Text) | string.IsNullOrEmpty(Digit6.Text))
            return;
        var IsAuthenticated = await _userService.LoginAsync(PhoneNumber, Digit1.Text + Digit2.Text + Digit3.Text + Digit4.Text + Digit5.Text + Digit6.Text);
        if (IsAuthenticated)
            await Shell.Current.GoToAsync($"//MainPage");

        else
            await DisplayAlert("خطا", "رمز عبور اشتباه است", "باشه");




    }
}