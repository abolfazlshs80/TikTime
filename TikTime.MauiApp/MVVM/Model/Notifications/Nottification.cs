using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.Tools.Static;
using TikTime.MauiApp.Tools.Static.ExtentionMethod;
namespace TikTime.MauiApp.MVVM.Model.Notifications
{
    public class Nottification
    {
        public Nottification()
        {
            
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string TimeAgo { get { return Date.GetTimeAgo(); } }
    }
}
