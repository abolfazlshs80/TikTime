﻿using System;
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
            model.Date = DateOnly.FromDateTime(DateTime.Now);
            var findUser = FakeDataService.Instance.Customers
                .Any(u => u.Phone == model.Phone);
            if (!findUser)
                FakeDataService.Instance.Customers.Add(model);

            return true;
        }

        public async Task<bool> Update(Customer model)
        {
            var FindCustomer = FakeDataService.Instance.Customers
                .FirstOrDefault(u => u.Id.Equals(model.Id));
            if (FindCustomer is not null)
            {
                FindCustomer.BrithDay = model.BrithDay;
                FindCustomer.Name = model.Name;
                FindCustomer.Phone = model.Phone;
                FindCustomer.SocialMediaPlatforms = model.SocialMediaPlatforms;
                FindCustomer.CustomerJob = model.CustomerJob;
                FindCustomer.CustomerCategory = model.CustomerCategory;
            }
            return true;
        }

        public async Task<bool> Remove(int Id)
        {
            var FindCustomer = FakeDataService.Instance.Customers
                .FirstOrDefault(u => u.Id.Equals(Id));
            if (FindCustomer is not null)
                FakeDataService.Instance.Customers.Remove(FindCustomer);
            return true;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return FakeDataService.Instance.Customers;
        }

        public async Task<Customer> Get(int Id)
        {
            return FakeDataService.Instance.Customers
                      .FirstOrDefault(u => u.Id.Equals(Id));
        }
    }

    public interface ICustomerService
    {
        Task<bool> Add(Customer model);
        Task<bool> Update(Customer model);
        Task<bool> Remove(int Id);
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> Get(int Id);

    }



}
