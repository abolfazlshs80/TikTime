using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiPersianToolkit;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.Service;
using TikTime.MauiApp.Tools.Static;
using TikTime.MauiApp.Tools.Static.ExtentionMethod;
using TikTime.MauiApp.MVVM.Model.Nobat;

namespace TikTime.MauiApp.MVVM.ViewModel.Nobat
{
    [AddINotifyPropertyChangedInterface]
    public class ListNobatViewModel
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ICustomerService customerService;
        private readonly IServiceService serviceService;
        private readonly INobatService nobatService;

        public ListNobatViewModel(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.customerService = serviceProvider.GetRequiredService<ICustomerService>();
            this.serviceService = serviceProvider.GetRequiredService<IServiceService>();
            this.nobatService = serviceProvider.GetRequiredService<INobatService>();

        }

        public async void LoadData( DateTime currentDate)
        {
            StartDate = currentDate.ToPersianDate();
            AppointmentDays.Clear();
            Nobats = new List<Model.Nobat.Nobat>();
            Nobats = await nobatService.GetAll();

            for (int i = currentDate.DayToShamsi(); i < 29; i++)
            {
                AppointmentDays.Add(new AppointmentDay()
                {
                    Month = PersianTools.GetPersianMonthName(currentDate.MonthToShamsi()),
                    Day = i,
                    Nobats =new(Nobats.Where(_ => 
                                                int.Parse(_.StartDate.Split('-')[2]) == i &&
                                               int.Parse(_.StartDate.Split('-')[1]) == currentDate.MonthToShamsi() &&
                                               int.Parse(_.StartDate.Split('-')[0]) == currentDate.YearToShamsi())),
                    HasAppointments = false
                });
            }

        }

        public ICommand OnDateSelected => new Command(async (date) =>
        {
            var a = date.ToString().ToMiladi();
            LoadData(a);
        });


        public string StartDate { get; set; }
        public ObservableCollection<AppointmentDay> AppointmentDays { get; set; } = new();
        public IEnumerable<Model.Nobat.Nobat> Nobats { get; set; }
    }
}
