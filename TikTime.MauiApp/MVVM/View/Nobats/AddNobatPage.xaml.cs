using TikTime.MauiApp.MVVM.ViewModel.Nobat;

namespace TikTime.MauiApp.MVVM.View.Nobats;

public partial class AddNobatPage : ContentPage
{
    public AddNobatPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        var model = new AddNobatViewModel(serviceProvider);
        model.LoadData();
        BindingContext = model;

    }

    private void NobatButton_OnClicked(object? sender, EventArgs e)
    {
        if (BindingContext is AddNobatViewModel vm)
        {
            vm.OnSubmitButton?.Execute(new object());
        }
    }
}