using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.MVVM.Model.Nobat
{
    [AddINotifyPropertyChangedInterface]
    public class Nobat: INotifyPropertyChanged
    {
        private bool _showItems = false;


        public int Id { get; set; }
        public string Desc { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }

        public bool ShowItems
        {
            get { return _showItems; }
            set
            {
                _showItems = value;
                onPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string Probname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Probname));
        }
        public int ServiceId { get; set; }
        public Service.Service Service { get; set; } = new();


        public int CustomerId { get; set; }
        public Customer.Customer Customer { get; set; } = new();
    }
}
