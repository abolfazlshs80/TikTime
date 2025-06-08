using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.MVVM.Model.Enums
{
    public enum CustomerJob
    {
        Other,
        Consultant,
        Accountant,
        Designer,
        Photographer,
        Singer,
        Worker,
        GovernmentEmployee,
        PrivateSectorEmployee,
        BankEmployee,
        Hairdresser,
        UniversityProfessor,
        Teacher,
        Lawyer,
        Engineer,
        Nurse,
        Dentist,
        Doctor,
        BusinessManager,
        Housewife,
        SchoolStudent,
        UniversityStudent,
        Freelancer
    }
    public static class CustomerJobExtensions
    {
        public static string ToDisplayName(this CustomerJob job)
        {
            return job switch
            {
                CustomerJob.Other => "سایر",
                CustomerJob.Consultant => "مشاور",
                CustomerJob.Accountant => "حسابدار",
                CustomerJob.Designer => "طراح",
                CustomerJob.Photographer => "عکاس",
                CustomerJob.Singer => "خواننده",
                CustomerJob.Worker => "کارگر ساده",
                CustomerJob.GovernmentEmployee => "کارمند دولتی",
                CustomerJob.PrivateSectorEmployee => "کارمند بخش خصوصی",
                CustomerJob.BankEmployee => "کارمند بانک",
                CustomerJob.Hairdresser => "آرایشگر",
                CustomerJob.UniversityProfessor => "استاد دانشگاه",
                CustomerJob.Teacher => "معلم",
                CustomerJob.Lawyer => "وکیل",
                CustomerJob.Engineer => "مهندس",
                CustomerJob.Nurse => "پرستار",
                CustomerJob.Dentist => "دندان‌پزشک",
                CustomerJob.Doctor => "پزشک",
                CustomerJob.BusinessManager => "مدیر کسب‌وکار",
                CustomerJob.Housewife => "خانه‌دار",
                CustomerJob.SchoolStudent => "دانش‌آموز",
                CustomerJob.UniversityStudent => "دانشجو",
                CustomerJob.Freelancer => "آزاد",
                _ => "نامشخص"
            };
        }
    }
    public class JobToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CustomerJob job)
                return job.ToDisplayName();
    
            return "نامشخص";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return CustomerJob.Other; // پیاده‌سازی در صورت نیاز
        }
    }

}
