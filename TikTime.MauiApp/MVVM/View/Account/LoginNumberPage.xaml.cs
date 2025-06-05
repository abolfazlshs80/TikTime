namespace TikTime.MauiApp.MVVM.View.Account;

public partial class LoginNumberPage : ContentPage
{
	public LoginNumberPage()
	{
		InitializeComponent();
	}

    private async void LoginButton_OnClicked(object? sender, EventArgs e)
    {
        if (!NumberTextBox.Text.StartsWith("09") || !NumberTextBox.Text.Length.Equals(11))
        {
            await DisplayAlert("شماره اشتباه است", "شماره باید با 09 شروع شود و کامل باشد", "باشه");
            return;
        }

        await Shell.Current.GoToAsync($"//LoginPasswordPage?phone={NumberTextBox.Text}");

    }
}