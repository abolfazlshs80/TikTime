using Mopups.Pages;
using Mopups.Services;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.View.Customer;

public partial class AddCustomerDialog : PopupPage
{
    private readonly ICustomerService _customerService;
    private readonly IServiceProvider _serviceProvider;
    public AddCustomerDialog(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this._serviceProvider = serviceProvider;
        this._customerService = _serviceProvider.GetRequiredService<ICustomerService>(); ;
    }


    private async void OnLoginClicked(object sender, EventArgs e)
    {
        //var getAll = await _customerService.GetAll();
        if (string.IsNullOrWhiteSpace(nameEntry.Text))
        {
            await DisplayAlert("خطا", "نام را وارد کنید", "باشه");
            return;
        }
        if (!phoneEntry.Text.StartsWith("09") || !phoneEntry.Text.Length.Equals(11))
        {
            await DisplayAlert("شماره اشتباه است", "شماره باید با 09 شروع شود و کامل باشد", "باشه");
            return;
        }

        var result = await _customerService.Add(new Model.Customer.Customer() { Phone = phoneEntry.Text, Name = nameEntry.Text });
        if (result)
        {
            await MopupService.Instance.PopAsync(); // بستن دیالوگ
            await DisplayAlert("موفقیت", "مشتری جدید با موفقیت ثبت شد", "باشه");
            var whatsappUri = new Uri($"https://wa.me/{phoneEntry.Text.Substring(1)}?text=سلام");

            if (await Launcher.CanOpenAsync(whatsappUri))
            {
                await Launcher.OpenAsync(whatsappUri);
            }
            else
            {
                // واتساپ نصب نیست یا باز کردن URI پشتیبانی نمی‌شود
                await Application.Current.MainPage.DisplayAlert("خطا", "واتساپ نصب نیست یا نمی‌توان باز کرد.", "باشه");
            }
            await Shell.Current.GoToAsync("//MainPage");
        }
        await DisplayAlert("خطا", "   خطا در ثبت مشتری رخ داد", "باشه");
        //     await Shell.Current.GoToAsync("LoginPasswordPage"); // رفتن به صفحه بعد

    }
}