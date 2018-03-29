using Android.Content;
using Android.Text;
using Android.Text.Style;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamCustomPlaceholderFont.Controls;
using XamCustomPlaceholderFont.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(CustomPlaceholderEntry), typeof(CustomPlaceholderEntryRenderer))]
namespace XamCustomPlaceholderFont.Droid.CustomRenderers
{
    public class CustomPlaceholderEntryRenderer : EntryRenderer
    {
        private CustomPlaceholderEntry CustomElement => Element as CustomPlaceholderEntry;

        public CustomPlaceholderEntryRenderer(Context context) : base(context)
        { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            UpdatePlaceholderFont();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CustomPlaceholderEntry.PlaceholderFontProperty.PropertyName)
                UpdatePlaceholderFont();
        }

        private void UpdatePlaceholderFont()
        {
            if (CustomElement.PlaceholderFont == Font.Default)
            {
                Control.HintFormatted = null;
                Control.Hint = CustomElement.Placeholder;
                Control.SetHintTextColor(CustomElement.PlaceholderColor.ToAndroid());
                return;
            }

            var placeholderFontSize = 30; //TODO: Work out correct height
            var placeholderSpan = new SpannableString(CustomElement.Placeholder);
            placeholderSpan.SetSpan(new AbsoluteSizeSpan(placeholderFontSize, false), 0, placeholderSpan.Length(), SpanTypes.InclusiveExclusive); // Set Fontsize

            var typeFaceSpan = new CustomTypefaceSpan(CustomElement.PlaceholderFont.ToTypeface());
            placeholderSpan.SetSpan(typeFaceSpan, 0, placeholderSpan.Length(), SpanTypes.InclusiveExclusive); //Set Fontface

            Control.HintFormatted = placeholderSpan;
        }
    }
}