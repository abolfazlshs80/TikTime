using DynamicData;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.MVVM.Model.Enums;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.ViewModel.Customer
{
    [AddINotifyPropertyChangedInterface]
    public class ListCustomerViewModel : INotifyPropertyChanged
    {
        private readonly ICustomerService _customerService;
        public ListCustomerViewModel(IServiceProvider serviceProvider)
        {
            this._customerService = serviceProvider.GetRequiredService<ICustomerService>();
            Customers = new ObservableCollection<Model.Customer.Customer>(_customerService.GetAll().Result);
        }

        public ICommand DeleteCustomerCommand => new Command(async (customer) =>
        {
            var model = customer as Model.Customer.Customer;
            var status = await _customerService.Remove(model.Id);
            if (status)
                Customers.Remove(model);
        });

        public ICommand EditProfileCustomer => new Command(async (customer) =>
        {
            var model = customer as Model.Customer.Customer;
            NavigationDataStore.Instance.Parameter = model.Id;
            await Shell.Current.GoToAsync("EditCustomerPage");
        });

        private ObservableCollection<Model.Customer.Customer> _customers;
        public ObservableCollection<Model.Customer.Customer> Customers
        {
            get { return _customers;}
            set {  _customers=value;
                onPropertyChanged();
            }
        }


        #region SearchCustomerPage
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string Probname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Probname));
        }


        public ICommand SearchBarNameCustomer_OnTextChanged => new Command(async (customer) =>
        {


            Customers.Clear();
            Customers = new ObservableCollection<Model.Customer.Customer>(_customerService.GetByText(customer.ToString()).Result);
            //if (!Customers.Any())
            //    Customers.AddRange(_customerService.GetAll().Result);

        });


        #endregion

        public ICommand OrderCustomer => new Command(async (type) =>
        {

            var model=Enum.Parse<OrderCustomerType>(type.ToString());
            Customers.Clear();
            Customers = new ObservableCollection<Model.Customer.Customer>(await _customerService.GetAll(model));
            //if (!Customers.Any())
            //    Customers.AddRange(_customerService.GetAll().Result);

        });

        #region Order



        #endregion

    }
}
