namespace TikTime.MauiApp.MVVM.View.Account;

public partial class LoginPasswordPage : ContentPage
{
	public LoginPasswordPage()
	{
		InitializeComponent();
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

}