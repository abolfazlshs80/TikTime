using System.Collections.ObjectModel;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.View.Main;

public partial class SettingPage : ContentPage
{
	public SettingPage()
	{
		InitializeComponent();
        GroupsCustomer = new ObservableCollection<string>(FakeDataService.Instance.GroupsCustomer);
        Ref = new ObservableCollection<string>(FakeDataService.Instance.Ref);
        BindingContext = this;
        PickerRef.ItemsSource = Ref;
        PickerGroupCustomer.ItemsSource = GroupsCustomer;
    }


    public ObservableCollection<string> GroupsCustomer;
    public ObservableCollection<string> Ref;
}