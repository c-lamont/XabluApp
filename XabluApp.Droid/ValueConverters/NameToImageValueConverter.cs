using System;
using Android.Content.Res;
using MvvmCross.Platform.Converters;

namespace XabluApp.Droid
{
    public class NameToImageValueConverter : MvxValueConverter<string, int>
    {
        protected override int Convert(string value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (int)typeof(Resource.Drawable).GetField(value).GetValue(null);
        }
    }
}
