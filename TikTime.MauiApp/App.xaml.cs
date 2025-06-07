using TikTime.MauiApp.MVVM.View.Customer;

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

            MainPage = new AppShell();
        }
    }
}
