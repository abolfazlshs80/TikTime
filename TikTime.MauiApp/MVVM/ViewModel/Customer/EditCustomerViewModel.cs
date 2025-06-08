using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TikTime.MauiApp.MVVM.Model.Enums;
using TikTime.MauiApp.Service;

namespace TikTime.MauiApp.MVVM.ViewModel.Customer
{
    [AddINotifyPropertyChangedInterface]
    public class EditCustomerViewModel
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ICustomerService customerService;
        public EditCustomerViewModel(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.customerService = serviceProvider.GetRequiredService<ICustomerService>();
            Customer = customerService.Get(CustomerId).Result;


        }

        public void LoadCustomer()
        {
            Customer = customerService.Get(CustomerId).Result;

            JobList = Enum.GetValues(typeof(CustomerJob)).Cast<CustomerJob>().ToList();
            SelectedJob = Customer.CustomerJob;

            CustomerCategoryList = Enum.GetValues(typeof(CustomerCategory)).Cast<CustomerCategory>().ToList();
            SelectedCustomerCategory = Customer.CustomerCategory;

            SocialMediaPlatformsList = Enum.GetValues(typeof(SocialMediaPlatforms)).Cast<SocialMediaPlatforms>().ToList();
            SelectedSocialMediaPlatforms = Customer.SocialMediaPlatforms;
        }



        public List<CustomerJob> JobList { get; set; }
        public CustomerJob SelectedJob { get; set; }


        public List< CustomerCategory>  CustomerCategoryList { get; set; }
        public  CustomerCategory SelectedCustomerCategory { get; set; }



        public List<SocialMediaPlatforms> SocialMediaPlatformsList { get; set; }
        public SocialMediaPlatforms SelectedSocialMediaPlatforms { get; set; }


        public int CustomerId { get; set; }
        public Model.Customer.Customer Customer { get; set; }


        public ICommand OnJobSelectedCommand => new Command(async (date) =>
        {
            Customer.CustomerJob = SelectedJob;
            Customer.CustomerCategory = SelectedCustomerCategory;
            Customer.SocialMediaPlatforms = SelectedSocialMediaPlatforms;
            await customerService.Update(Customer);
        });
     
        public ICommand OnDateSelected => new Command(async (date) =>
        {
            Customer.BrithDay = date.ToString();
           await customerService.Update(Customer);
        });
    }
}
