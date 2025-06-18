using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.MVVM.Model.Nobat
{
    [AddINotifyPropertyChangedInterface]
    public class Nobat
    {


        public int Id { get; set; }
        public string Desc { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public bool ShowItems { get; set; } = false;


        public int ServiceId { get; set; }
        public Service.Service Service { get; set; } = new();


        public int CustomerId { get; set; }
        public Customer.Customer Customer { get; set; } = new();
    }
}
