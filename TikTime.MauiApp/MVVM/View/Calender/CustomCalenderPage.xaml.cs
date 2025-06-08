using CommunityToolkit.Maui.Views;
using System.Windows.Input;

namespace TikTime.MauiApp.MVVM.View.Calender;

public partial class CustomCalenderPage : Popup
{
	public CustomCalenderPage()
	{
		InitializeComponent();
        BindingContext=this;
	}
    public ICommand OnDateSelected => new Command(async (date) =>
    {
      
    });
    //private void OnDateSelected(object sender, DateChangedEventArgs e)
    //{
    //    OnDatePicked?.Invoke(e.NewDate.ToString("yyyy/MM/dd"));
    //    Close();
    //}
}