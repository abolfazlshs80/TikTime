using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.ViewModel.Nobat
{
    [AddINotifyPropertyChangedInterface]
    public class AddNobatViewModel
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ICustomerService customerService;
        private readonly IServiceService serviceService;
        private readonly INobatService nobatService;

        public AddNobatViewModel(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.customerService = serviceProvider.GetRequiredService<ICustomerService>();
            this.serviceService = serviceProvider.GetRequiredService<IServiceService>();
            this.nobatService = serviceProvider.GetRequiredService<INobatService>();

        }

        public async void LoadData()
        {
            ServicesList = new ObservableCollection<Model.Service.Service>(await serviceService.GetAll());
            Customer = await customerService.Get(int.Parse(NavigationDataStore.Instance.Parameter?.ToString()??"0"))??new Model.Customer.Customer();
        }

        public ICommand OnDateSelected => new Command(async (date) =>
        {

        });
        public ICommand OnSubmitButton => new Command(async (date) =>
        {
            Nobat.Customer = Customer;
            Nobat.CustomerId = Customer.Id;

            Nobat.Service = SelectedService;
            Nobat.ServiceId = SelectedService.Id;

            Nobat.StartTime = SelectedTime.ToString();
            await nobatService.Add(Nobat);

            await Shell.Current.GoToAsync($"ListNobatPage");
        });

        public TimeSpan SelectedTime { get; set; } = new();
        public Model.Service.Service SelectedService { get; set; } = new();
        public Model.Customer.Customer Customer { get; set; } = new();
        public Model.Nobat.Nobat Nobat { get; set; } = new();

        public ObservableCollection<Model.Service.Service> ServicesList { get; set; } = new();
    }
}
