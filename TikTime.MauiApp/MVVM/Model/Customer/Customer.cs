using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTime.MauiApp.MVVM.Model.Enums;
using TikTime.MauiApp.Tools.Static.ExtentionMethod;

namespace TikTime.MauiApp.MVVM.Model.Customer
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Desc { get; set; } = "dont have desc";
        public DateOnly Date { get; set; }
        public SocialMediaPlatforms SocialMediaPlatforms { get; set; } = SocialMediaPlatforms.ContactsAndFriends;
        public CustomerJob CustomerJob { get; set; } = CustomerJob.Other;
        public CustomerCategory CustomerCategory { get; set; } = CustomerCategory.Employees;
        public string BrithDay { get; set; }=DateTime.Now.ToShamsi();
    }
}
