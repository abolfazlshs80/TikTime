using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.MVVM.Model.Enums
{
    public enum CustomerCategory
    {
        Colleagues,
        Employees,
        Relatives,
        Organizational,
        VIPCustomers
    }
    public static class CustomerCategoryExtensions
    {
        public static string ToDisplayName(this CustomerCategory category)
        {
            return category switch
            {
                CustomerCategory.Colleagues => "همکاران",
                CustomerCategory.Employees => "کارکنان",
                CustomerCategory.Relatives => "بستگان",
                CustomerCategory.Organizational => "سازمانی",
                CustomerCategory.VIPCustomers => "مشتریان مهم",
                _ => "سایر"
            };
        }
    }

    public class CustomerCategoryToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CustomerCategory customerCategory)
                return customerCategory.ToDisplayName();
            return "نامشخص";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return CustomerCategory.Employees; // پیاده‌سازی در صورت نیاز
        }
    }

}
