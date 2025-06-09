using TikTime.MauiApp.MVVM.View.Calender;
using TikTime.MauiApp.MVVM.View.Customer;
using TikTime.MauiApp.MVVM.View.Nobats;

namespace TikTime.MauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddCustomerPage), typeof(AddCustomerPage));
            Routing.RegisterRoute(nameof(EditCustomerPage), typeof(EditCustomerPage));
            Routing.RegisterRoute(nameof(ListCustomerPage), typeof(ListCustomerPage));
            Routing.RegisterRoute(nameof(CustomCalenderPage), typeof(CustomCalenderPage));
            Routing.RegisterRoute(nameof(AddNobatPage), typeof(AddNobatPage));

            MainPage = new AppShell();
        }
    }
}
