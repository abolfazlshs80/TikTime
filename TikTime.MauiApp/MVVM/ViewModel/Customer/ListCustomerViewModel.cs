using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.ViewModel.Customer
{
    [AddINotifyPropertyChangedInterface]
    public class ListCustomerViewModel
    {
        private readonly ICustomerService _customerService;
        public ListCustomerViewModel(IServiceProvider serviceProvider)
        {
            this._customerService = serviceProvider.GetRequiredService<ICustomerService>();
            Customers = new ObservableCollection<Model.Customer.Customer>(_customerService.GetAll().Result);
        }

        public ICommand DeleteCustomerCommand => new Command(async(customer) =>
        {
            var model = customer as Model.Customer.Customer;
            var status =await _customerService.Remove(model.Id);
            if (status)
                Customers.Remove(model);
        });

        public ICommand EditProfileCustomer => new Command(async (customer) =>
        {
            var model = customer as Model.Customer.Customer;
            await Shell.Current.GoToAsync($"EditCustomerPage?CustomerId={model.Id}");
        });

        public ObservableCollection<Model.Customer.Customer> Customers { get; set; }
    }
}
