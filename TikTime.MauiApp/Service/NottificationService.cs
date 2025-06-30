using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model.Notifications;

namespace TikTime.MauiApp.Service
{
    public class NottificationService : INottificationService
    {
        public async Task<bool> Add(Nottification Nottification)
        {
            FakeDataService.Instance.Nottification.Add(Nottification);
            return true;
        }

        public async Task<IEnumerable<Nottification>> GetAll()
        {
            return FakeDataService.Instance.Nottification;
        }
    }

    public interface INottificationService
    {
        Task<bool> Add(Nottification Nottification);
        Task<IEnumerable<Nottification>> GetAll();

    }



}
