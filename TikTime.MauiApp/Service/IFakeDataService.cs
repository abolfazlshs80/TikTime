using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model.Account;

namespace TikTime.MauiApp.Service
{
    public interface IFakeDataService
    {
    }


    public class FakeDataService : IFakeDataService
    {
        private FakeDataService() { }


        public static FakeDataService Instance { get; } = new FakeDataService();

        public  List<User> Users = new List<User>()
        {
            new User() { UserName = "09389114506", Password = "123" },
            new User() { UserName = "09389114505", Password = "123" },
            new User() { UserName = "09389114504", Password = "123" },
        };
    }
}

