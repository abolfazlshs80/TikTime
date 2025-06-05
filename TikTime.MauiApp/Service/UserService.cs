using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.Service
{
    public class UserService : IUserService
    {
        public async Task<bool> LoginAsync(string username, string password)
        {
            var findUser = FakeDataService.Instance.Users
                .Any(u => u.UserName == username && u.Password == password);
            if (!findUser)
                FakeDataService.Instance.Users.Add(new MVVM.Model.Account.User() { UserName = username, Password = password });

            return true;
        }
    }

    public interface IUserService
    {
        Task<bool> LoginAsync(string username, string password);

    }



}
