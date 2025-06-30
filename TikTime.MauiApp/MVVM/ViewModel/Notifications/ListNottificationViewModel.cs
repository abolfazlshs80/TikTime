using DynamicData;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TikTime.MauiApp.MVVM.Model;
using TikTime.MauiApp.MVVM.Model.Enums;
using TikTime.MauiApp.Service;
using TikTime.MauiApp.MVVM.Model.Notifications;
namespace TikTime.MauiApp.MVVM.ViewModel.Nottifications
{
    [AddINotifyPropertyChangedInterface]
    public class ListNottificationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly INottificationService _NottificationService;

        protected void onPropertyChanged([CallerMemberName] string Probname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Probname));
        }


        public ListNottificationViewModel(IServiceProvider serviceProvider)
        {
            this._NottificationService = serviceProvider.GetRequiredService<INottificationService>();
            var a = _NottificationService.GetAll().Result;
            NottificationCollectionView = new ObservableCollection<Nottification>(a);
        }

        public ICommand GoNottificationCommand => new Command(async (Nottification) =>
        {

        });



        private ObservableCollection<Nottification> _Nottifications;
        public ObservableCollection<Nottification> NottificationCollectionView
        {
            get { return _Nottifications; }
            set
            {
                _Nottifications = value;
                onPropertyChanged();
            }
        }




    }
}
