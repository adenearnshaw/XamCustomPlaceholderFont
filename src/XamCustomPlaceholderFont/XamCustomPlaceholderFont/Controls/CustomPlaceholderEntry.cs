using Xamarin.Forms;

namespace XamCustomPlaceholderFont.Controls
{
    public class CustomPlaceholderEntry : Entry
    {
        public static readonly BindableProperty PlaceholderFontProperty
            = BindableProperty.Create(nameof(PlaceholderFont), typeof(Font), typeof(CustomPlaceholderEntry), default(Font));

        public Font PlaceholderFont
        {
            get { return (Font)GetValue(PlaceholderFontProperty); }
            set { SetValue(PlaceholderFontProperty, value); }
        }
    }
}