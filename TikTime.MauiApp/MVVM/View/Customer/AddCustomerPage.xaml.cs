using Mopups.Services;

namespace TikTime.MauiApp.MVVM.View.Customer;

public partial class AddCustomerPage : ContentPage
{
    private IServiceProvider _serviceProvider;

    public AddCustomerPage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        _serviceProvider = serviceProvider;
    }


    private async void OnAddNoteClicked(object sender, EventArgs e)
    {
        // Handle add note action
        // await DisplayAlert("افزودن نکی", "Add note functionality", "OK");

        var popup = new AddCustomerDialog(_serviceProvider);
        await MopupService.Instance.PushAsync(popup);
    }

    private async void OnExcelFileClicked(object sender, EventArgs e)
    {
        // Handle excel file action
        await DisplayAlert("فایل اکسل", "Excel file functionality", "OK");
    }

    private async void OnGroupContactsClicked(object sender, EventArgs e)
    {
        // Handle group contacts action
        await DisplayAlert("مخاطبین گروهی", "Group contacts functionality", "OK");
    }
}