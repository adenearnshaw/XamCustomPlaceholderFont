using Android.Graphics;
using Android.Text;
using Android.Text.Style;

namespace XamCustomPlaceholderFont.Droid.CustomRenderers
{
    public class CustomTypefaceSpan : TypefaceSpan
    {
        private readonly Typeface _customTypeface;

        public CustomTypefaceSpan(Typeface type) : base("")
        {
            _customTypeface = type;
        }

        public CustomTypefaceSpan(string family, Typeface type) : base(family)
        {
            _customTypeface = type;
        }

        public override void UpdateDrawState(TextPaint ds)
        {
            ApplyCustomTypeFace(ds, _customTypeface);
        }

        public override void UpdateMeasureState(TextPaint paint)
        {
            ApplyCustomTypeFace(paint, _customTypeface);
        }

        private static void ApplyCustomTypeFace(Paint paint, Typeface tf)
        {
            paint.SetTypeface(tf);
        }
    }
}