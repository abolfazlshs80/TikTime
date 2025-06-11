using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model.Account;
using TikTime.MauiApp.MVVM.Model.Customer;
using TikTime.MauiApp.MVVM.Model.Enums;
using TikTime.MauiApp.MVVM.Model.Nobat;

namespace TikTime.MauiApp.Service
{
    public interface IFakeDataService
    {
    }


    public class FakeDataService : IFakeDataService
    {
        private FakeDataService()
        {
            Users = new List<User>()
            {
                new User() { UserName = "09389114506", Password = "123" },
                new User() { UserName = "09389114505", Password = "123" },
                new User() { UserName = "09389114504", Password = "123" },
            };
            Services = new()
            {
                new () { Id = 1,Name = "Service 1"},
                new () {  Id = 2,Name = "Service 2" },
                new () {  Id = 3,Name = "Service 3" },
            };

            Customers = new List<Customer>()
            {
                new (){Id = 1,Name = "abolfazl",Desc = "توضیحات",Phone = "09389114506",Date = DateOnly.FromDateTime(DateTime.Now),CustomerCategory = CustomerCategory.Employees,CustomerJob = CustomerJob.Other,SocialMediaPlatforms = SocialMediaPlatforms.Google},
                new (){Id = 2,Name = "mohsen",Desc = "توضیحات",Phone = "09389114206",Date = DateOnly.FromDateTime(DateTime.Now),CustomerCategory = CustomerCategory.Employees,CustomerJob = CustomerJob.Other,SocialMediaPlatforms = SocialMediaPlatforms.Google}
            };
            Nobat = new List<Nobat>();
            Nobat = new()
            {
                new () { Id = 1,Desc = "Desc 1" ,StartDate = "1404/3/20" ,StartTime = "20:20:20",
                    Service =    new () { Id = 1,Name = "Service 1"},ServiceId =1,
                    Customer =         new (){Id = 1,Name = "mohsen",Desc = "توضیحات",Phone = "09389114206",Date = DateOnly.FromDateTime(DateTime.Now),CustomerCategory = CustomerCategory.Employees,CustomerJob = CustomerJob.Other,SocialMediaPlatforms = SocialMediaPlatforms.Google}
                    ,CustomerId = 1},
                new () {  Id = 2,Desc= "Desc 2",StartDate = "1404/3/21" ,StartTime = "21:20:20",
                    Service =    new () { Id = 1,Name = "Service 2"},ServiceId =2,
                    Customer =         new (){Id = 1,Name = "mohsen",Desc = "توضیحات",Phone = "09389114206",Date = DateOnly.FromDateTime(DateTime.Now),CustomerCategory = CustomerCategory.Employees,CustomerJob = CustomerJob.Other,SocialMediaPlatforms = SocialMediaPlatforms.Google}
                    ,CustomerId = 1 },


                new () {  Id = 3,Desc= "Desc 3",StartDate = "1404/3/20" ,StartTime = "21:20:20",
                    Service =    new () { Id = 1,Name = "Service 2"},ServiceId =2,
                    Customer =         new (){Id = 1,Name = "mohsen",Desc = "توضیحات",Phone = "09389114206",Date = DateOnly.FromDateTime(DateTime.Now),CustomerCategory = CustomerCategory.Employees,CustomerJob = CustomerJob.Other,SocialMediaPlatforms = SocialMediaPlatforms.Google}
                    ,CustomerId = 1 },
            };






        }


        public static FakeDataService Instance { get; } = new FakeDataService();

        public List<User> Users;

        public List<MVVM.Model.Service.Service> Services;

        public List<MVVM.Model.Nobat.Nobat> Nobat;

        public List<Customer> Customers;
    }
}

