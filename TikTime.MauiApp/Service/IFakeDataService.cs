using DynamicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model.Account;
using TikTime.MauiApp.MVVM.Model.Customer;
using TikTime.MauiApp.MVVM.Model.Enums;
using TikTime.MauiApp.MVVM.Model.Nobat;
using TikTime.MauiApp.MVVM.Model.Notifications;

namespace TikTime.MauiApp.Service
{
    public class FakeDataModel
    {
        public List<string> GroupsCustomer { get; set; }
        public List<string> Ref { get; set; }
        public List<User> Users { get; set; }
        public List<MVVM.Model.Service.Service> Services { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Nobat> Nobat { get; set; }
        public List<Nottification> Nottification { get; set; }
    }

    public interface IFakeDataService
    {
    }


    public class FakeDataService : IFakeDataService
    {
        private FakeDataService()
        {


            LoadFromJson();

        }

        private async void LoadFromJson()
        {

            using var stream = await FileSystem.OpenAppPackageFileAsync("data.json");
            using var reader = new StreamReader(stream);
           
            var data = JsonSerializer.Deserialize<FakeDataModel>(reader.ReadToEnd());

            GroupsCustomer = data?.GroupsCustomer ?? new();
            Ref = data?.Ref ?? new();
            Users = data?.Users ?? new();
            Services = data?.Services ?? new();
            Customers = data?.Customers ?? new();
            Nobat = data?.Nobat ?? new();
            Nottification = data?.Nottification ?? new();
        }
        public static FakeDataService Instance { get; } = new FakeDataService();

        public List<User> Users;

        public List<MVVM.Model.Service.Service> Services;

        public List<MVVM.Model.Nobat.Nobat> Nobat;
        public List<MVVM.Model.Notifications.Nottification> Nottification;

        public List<Customer> Customers;
        public List<string> GroupsCustomer;
        public List<string> Ref;
    }
}

