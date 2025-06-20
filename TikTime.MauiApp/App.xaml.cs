using TikTime.MauiApp.MVVM.View.Calender;
using TikTime.MauiApp.MVVM.View.Customer;
using TikTime.MauiApp.MVVM.View.Main;
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
            Routing.RegisterRoute(nameof(ListNobatPage), typeof(ListNobatPage));
            Routing.RegisterRoute(nameof(SearchCustomerPage), typeof(SearchCustomerPage));
            Routing.RegisterRoute(nameof(MVVM.View.Main.MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(MVVM.View.Main.NotificationPage), typeof(NotificationPage));

            MainPage = new AppShell();
        }
    }
}
