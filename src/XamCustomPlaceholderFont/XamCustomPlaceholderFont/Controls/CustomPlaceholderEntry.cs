using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace XamCustomPlaceholderFont.Controls
{
    public class CustomPlaceholderEntry : Entry
    {
        public static readonly BindableProperty PlaceholderFontFamilyProperty
        = BindableProperty.Create(nameof(PlaceholderFontFamily), typeof(string), typeof(CustomPlaceholderEntry), default(string));

        public string PlaceholderFontFamily
        {
            get { return (string)GetValue(PlaceholderFontFamilyProperty); }
            set { SetValue(PlaceholderFontFamilyProperty, value); }
        }
    }
}