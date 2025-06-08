using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.MVVM.Model
{
    public class NavigationDataStore
    {
        private NavigationDataStore()
        {
            
        }

        public static NavigationDataStore Instance { get; } = new NavigationDataStore();
        public object Parameter { get; set; }
    }

}
