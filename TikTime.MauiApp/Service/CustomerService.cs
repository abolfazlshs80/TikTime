using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model.Customer;

namespace TikTime.MauiApp.Service
{
    public class CustomerService : ICustomerService
    {
        public async Task<bool> LoginAsync(string username, string password)
        {
            var findUser = FakeDataService.Instance.Users
                .Any(u => u.UserName == username && u.Password == password);
            if (!findUser)
                FakeDataService.Instance.Users.Add(new MVVM.Model.Account.User() { UserName = username, Password = password });

            return true;
        }

        public async Task<bool> Add(Customer model)
        {
            var findUser = FakeDataService.Instance.Customers
                .Any(u => u.Phone == model.Phone);
            if (!findUser)
                FakeDataService.Instance.Customers.Add(model);

            return true;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return FakeDataService.Instance.Customers;
        }
    }

    public interface ICustomerService
    {
        Task<bool> Add(Customer model);
        Task<IEnumerable<Customer>> GetAll();

    }



}
