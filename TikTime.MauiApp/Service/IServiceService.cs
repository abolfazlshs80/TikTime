using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model;

namespace TikTime.MauiApp.Service
{
    public class ServiceService : IServiceService
    {
     

        public async Task<bool> Add(MVVM.Model.Service.Service service)
        {
            FakeDataService.Instance.Services.Add(new () { Id = FakeDataService.Instance.Services.LastOrDefault().Id+1});
            return true;
        }

        public async Task<IEnumerable<MVVM.Model.Service.Service>> GetAll()
        {
            return FakeDataService.Instance.Services;
        }
    }

    public interface IServiceService
    { 
        Task<bool> Add(MVVM.Model.Service.Service service);
        Task<IEnumerable<MVVM.Model.Service.Service>> GetAll();

    }



}
