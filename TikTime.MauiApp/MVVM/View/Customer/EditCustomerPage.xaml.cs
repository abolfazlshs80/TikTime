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

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void OnMenuClicked(object sender, EventArgs e)
    {
        DisplayAlert("Menu", "Menu clicked", "OK");
    }

    private async void OnBirthClicked(object sender, EventArgs e)
    {
        await DisplayAlert("تولد", "ویرایش تاریخ تولد", "تایید");
    }

    private async void OnJobClicked(object sender, EventArgs e)
    {
        await DisplayAlert("شغل", "ویرایش شغل مشتری", "تایید");
    }

    private async void OnHowFoundUsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("نحوه آشنایی", "ویرایش نحوه آشنایی", "تایید");
    }

    private void OnSettingsClicked(object sender, EventArgs e)
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
    //private void JobPicker_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (BindingContext is EditCustomerViewModel vm)
    //    {
    //        if (JobPicker.SelectedItem is CustomerJob selectedJob)
    //            vm.OnJobSelectedCommand?.Execute(selectedJob);
    //    }
    //}

    //private void CustomerCategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (BindingContext is EditCustomerViewModel vm)
    //    {
    //        var selected = (CustomerCategory)CustomerCategoryPicker.SelectedItem;
    //        vm.OnJobSelectedCommand?.Execute(selected);
    //    }
    //}

    private void SocialMediaPlatformsPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (BindingContext is EditCustomerViewModel vm)
        {
            var selected = (SocialMediaPlatforms)SocialMediaPlatformsPicker.SelectedItem;
            vm.OnJobSelectedCommand?.Execute(selected);
        }
    }

    //private void NobatButton_OnClicked(object? sender, EventArgs e)
    //{
    //    if (BindingContext is EditCustomerViewModel vm)
    //    {
    //        vm.OnNobatCommand?.Execute(new object());
    //    }
    //}
}



