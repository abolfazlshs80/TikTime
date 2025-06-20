using MauiPersianToolkit;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.MVVM.Model.Nobat;
using TikTime.MauiApp.Service;
using TikTime.MauiApp.Tools.Static;
using TikTime.MauiApp.Tools.Static.ExtentionMethod;

namespace TikTime.MauiApp.MVVM.ViewModel.Nobat
{
    [AddINotifyPropertyChangedInterface]
    public class ListNobatViewModel: INotifyPropertyChanged
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

        public async void LoadData(DateTime currentDate)
        {
            StartDate = currentDate.ToPersianDate();
            AppointmentDays.Clear();
            Nobats = new ObservableCollection<Model.Nobat.Nobat>();
            Nobats =new( await nobatService.GetAll());

            for (int i = currentDate.DayToShamsi(); i < 29; i++)
            {
                //string tempMonth = PersianTools.GetPersianMonthName(currentDate.MonthToShamsi());
                //var n= Nobats.Where(_ =>
                //    int.Parse(_.StartDate.Split('-')[2]) == i &&
                //    int.Parse(_.StartDate.Split('-')[1]) == currentDate.MonthToShamsi() &&
                //    int.Parse(_.StartDate.Split('-')[0]) == currentDate.YearToShamsi()).ToList();
                AppointmentDays.Add(new AppointmentDay()
                {
                    Month = PersianTools.GetPersianMonthName(currentDate.MonthToShamsi()),
                    Day = i,
                    Nobats = new(Nobats.Where(_ =>
                                                int.Parse(_.StartDate.Split('/')[2]) == i &&
                                               int.Parse(_.StartDate.Split('/')[1]) == currentDate.MonthToShamsi() &&
                                               int.Parse(_.StartDate.Split('/')[0]) == currentDate.YearToShamsi())),
                    HasAppointments = false
                });
            }

        }

        public ICommand OnDateSelected => new Command(async (date) =>
        {
            var a = date.ToString().ToMiladi();
            LoadData(a);
        });
        public ICommand OnShowitems => new Command(async (nobat) =>
        {

            if (nobat is Model.Nobat.Nobat model)
            {
                model.ShowItems = !model.ShowItems;
            }
        });

        public string StartDate { get; set; }
        public ObservableCollection<AppointmentDay> _appointmentDays { get; set; } = new();
        public ObservableCollection<AppointmentDay> AppointmentDays
        {
            get { return _appointmentDays; }
            set
            {
                _appointmentDays = value;
                onPropertyChanged();
            }
        }
        public ObservableCollection<Model.Nobat.Nobat> Nobats { get; set; } = new();


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string Probname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Probname));
        }
    }
}
