using TikTime.MauiApp.MVVM.Model.Customer;
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
       

        public async Task<IEnumerable<Nobat>> GetAll()
        {
            
            return FakeDataService.Instance.Nobat;
        }
    }

    public interface INobatService
    {
        Task<bool> Add(Nobat nobat);
        Task<IEnumerable<Nobat>> GetAll();

    }



}
