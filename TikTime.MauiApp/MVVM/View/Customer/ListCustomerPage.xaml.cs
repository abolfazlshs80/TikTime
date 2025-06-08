using MauiPersianToolkit.Controls;
using MauiPersianToolkit.Models;
using MauiPersianToolkit.Services.Dialog;
using TikTime.MauiApp.MVVM.ViewModel.Customer;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.View.Customer;

public partial class ListCustomerPage : ContentPage
{
    private readonly ICustomerService _customerService;
    public ListCustomerPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this._customerService = serviceProvider.GetRequiredService<ICustomerService>();
        BindingContext = new ListCustomerViewModel(serviceProvider);

        //DialogService dialogService = new DialogService();



        //// Custom Dialog
        //dialogService.CustomDialog(new CustomDialogConfig()
        //{
        //    Title = "Register Information",
        //    AcceptText = "Register",
        //    CancelText = "Cancle",
        //    Message = "Enter Your Info",
        //    Icon = MessageIcon.QUESTION,
        //    AcceptIcon = MessageIcon.QUESTION,
        //    Cancelable = true,
        //    CancelIcon = MessageIcon.ERROR,
        //    DialogColor = Colors.DeepPink,
        //    CloseWhenBackgroundIsClicked = false,
        //    CloseAfterAccept = true,
        //    OnAction = new Action<bool>((arg) => { }),
        //    Content = new StackLayout()
        //    {
        //        Children =
        //        {
        //            new MauiPersianToolkit.Controls.DatePicker(){ PlaceHolder = "BirthDate" }
        //        }
        //    }
        //});
    }

    private async void AddCuctomerTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {

        await Shell.Current.GoToAsync($"AddCustomerPage");
    }
}