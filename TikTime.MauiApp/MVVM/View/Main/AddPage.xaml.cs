using Mopups.Services;

namespace TikTime.MauiApp.MVVM.View.Main;


public partial class AddPage : Mopups.Pages.PopupPage
{
    public AddPage()
    {
        InitializeComponent();
    }

    private async void ClosePopup(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAsync();
    }
}