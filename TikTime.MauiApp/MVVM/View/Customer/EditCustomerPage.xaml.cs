using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.MVVM.Model.Enums;
using TikTime.MauiApp.MVVM.ViewModel.Customer;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.View.Customer;
//[QueryProperty(nameof(CustomerId), "CustomerId")]
public partial class EditCustomerPage : ContentPage
{
    public int CustomerId { get; set; }
    public EditCustomerPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        CustomerId = int.Parse(NavigationDataStore.Instance.Parameter.ToString());
        var model = new EditCustomerViewModel(serviceProvider) { CustomerId = CustomerId };
        model.CustomerId = CustomerId;
        model.LoadCustomer();
        BindingContext = model;


    }

    private void JobPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (BindingContext is EditCustomerViewModel vm)
        {
            if (JobPicker.SelectedItem is CustomerJob selectedJob)
                vm.OnJobSelectedCommand?.Execute(selectedJob);
        }
    }

    private void CustomerCategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (BindingContext is EditCustomerViewModel vm)
        {
            var selected = (CustomerCategory)CustomerCategoryPicker.SelectedItem;
            vm.OnJobSelectedCommand?.Execute(selected);
        }
    }

    private void SocialMediaPlatformsPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (BindingContext is EditCustomerViewModel vm)
        {
            var selected = (SocialMediaPlatforms)SocialMediaPlatformsPicker.SelectedItem;
            vm.OnJobSelectedCommand?.Execute(selected);
        }
    }

    private void NobatButton_OnClicked(object? sender, EventArgs e)
    {
        if (BindingContext is EditCustomerViewModel vm)
        {
            vm.OnNobatCommand?.Execute(new object());
        }
    }
}