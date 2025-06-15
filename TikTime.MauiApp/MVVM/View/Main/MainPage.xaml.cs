namespace TikTime.MauiApp.MVVM.View.Main
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }

        private async void CuctomerTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync($"ListCustomerPage");
        }

        private async void NobatTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync($"ListNobatPage");
        }


        private void OnSettingsClicked(object sender, EventArgs e)
        {
            DisplayAlert("Settings", "Settings clicked", "OK");
        }

        private void OnListClicked(object sender, EventArgs e)
        {
            DisplayAlert("List", "List clicked", "OK");
        }

        private async void OnAddClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//AddCustomerPage");
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            DisplayAlert("Search", "Search clicked", "OK");
        }

        private void OnHomeClicked(object sender, EventArgs e)
        {
            DisplayAlert("Home", "Home clicked", "OK");
        }

        private async void NotificationTapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("NotificationPage");
        }
    }

}
