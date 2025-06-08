using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.MVVM.Model.Enums
{
    public enum SocialMediaPlatforms
    {
        Instagram,
        Google,
        ContactsAndFriends,
        MessagingApps,
        Notifications,
        SocialNetworksAndSheep
    }

    public static class SocialMediaPlatformsExtensions
    {
        public static string ToDisplayName(this SocialMediaPlatforms platform)
        {
            return platform switch
            {
                SocialMediaPlatforms.Instagram => "اینستاگرام",
                SocialMediaPlatforms.Google => "گوگل",
                SocialMediaPlatforms.ContactsAndFriends => "معرفی دوستان و آشنایان",
                SocialMediaPlatforms.MessagingApps => "تبلیغات پیامکی",
                SocialMediaPlatforms.Notifications => "ترافیک تبلیغاتی",
                SocialMediaPlatforms.SocialNetworksAndSheep => "سایتهای آگهی (دیوار و شیپور)",
                _ => "سایر"
            };
        }
    }


    public class SocialMediaPlatformsToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SocialMediaPlatforms mediaPlatforms)
                return mediaPlatforms.ToDisplayName();
            return "سایر";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return SocialMediaPlatforms.Google; // پیاده‌سازی در صورت نیاز
        }
    }
}
