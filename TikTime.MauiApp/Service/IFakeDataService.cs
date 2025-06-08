using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model.Account;
using TikTime.MauiApp.MVVM.Model.Customer;
using TikTime.MauiApp.MVVM.Model.Enums;

namespace TikTime.MauiApp.Service
{
    public interface IFakeDataService
    {
    }


    public class FakeDataService : IFakeDataService
    {
        private FakeDataService() { }


        public static FakeDataService Instance { get; } = new FakeDataService();

        public List<User> Users = new List<User>()
        {
            new User() { UserName = "09389114506", Password = "123" },
            new User() { UserName = "09389114505", Password = "123" },
            new User() { UserName = "09389114504", Password = "123" },
        };

        public List<Customer> Customers = new List<Customer>()
        {
            new Customer(){Id = 1,Name = "abolfazl",Desc = "توضیحات",Phone = "09389114506",Date = DateOnly.FromDateTime(DateTime.Now),CustomerCategory = CustomerCategory.Employees,CustomerJob = CustomerJob.Other,SocialMediaPlatforms = SocialMediaPlatforms.Google},
            new Customer(){Id = 2,Name = "mohsen",Desc = "توضیحات",Phone = "09389114206",Date = DateOnly.FromDateTime(DateTime.Now),CustomerCategory = CustomerCategory.Employees,CustomerJob = CustomerJob.Other,SocialMediaPlatforms = SocialMediaPlatforms.Google}
        };
    }
}

