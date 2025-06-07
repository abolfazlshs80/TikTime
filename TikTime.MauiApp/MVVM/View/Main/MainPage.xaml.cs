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
    }

}
