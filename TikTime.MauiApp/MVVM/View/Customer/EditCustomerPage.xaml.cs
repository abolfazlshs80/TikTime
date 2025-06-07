namespace TikTime.MauiApp.MVVM.View.Customer;
[QueryProperty(nameof(CustomerId), "CustomerId")]
public partial class EditCustomerPage : ContentPage
{
    public int CustomerId { get; set; }
	public EditCustomerPage()
	{
		InitializeComponent();
	
	}
}