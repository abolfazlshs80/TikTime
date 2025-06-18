using PropertyChanged;
using System.Collections.ObjectModel;

namespace TikTime.MauiApp.MVVM.Model.Nobat;

[AddINotifyPropertyChangedInterface]
public class AppointmentDay
{
    public ObservableCollection<Nobat> Nobats { get; set; }
    public int Day { get; set; }
    public string Month { get; set; }
    public int AppointmentCount
    {
        get { return Nobats.Count(); }

    }
    public bool HasAppointments { get; set; }
    public bool IsSpecial { get; set; } // For pink gradient
}