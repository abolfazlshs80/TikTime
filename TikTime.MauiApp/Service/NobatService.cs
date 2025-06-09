using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model.Nobat;

namespace TikTime.MauiApp.Service
{
    public class NobatService : INobatService
    {
        public async Task<bool> Add(Nobat nobat)
        {
            FakeDataService.Instance.Nobat.Add(nobat);
            return true;
        }
    }

    public interface INobatService
    {
        Task<bool> Add(Nobat nobat);

    }



}
