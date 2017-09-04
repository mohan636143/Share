using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Share.Droid.Renderers;
using Share.Controls;
using Android.Graphics.Drawables;
using Android.Content.Res;
using Android.Util;
using System;
using Android.Graphics.Drawables.Shapes;
using Android.Widget;

[assembly: ExportRenderer (typeof (ExtendedEntry), typeof (ExtendedEntryRenderer))]
namespace Share.Droid.Renderers
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
			if (this.Element == null)
				return;
            base.OnElementChanged(e);

            var extendedEntry = (ExtendedEntry)this.Element;
            switch (extendedEntry.EntryBorderStyle)
            {
                case EntryBorderStyleTypes.DefaultStyle:
                    break;
                case EntryBorderStyleTypes.NoBorderStyle:
                    Control.Background.Alpha = 0;
                    break;
            }

			Control.Background.Alpha = 0;
            switch (extendedEntry.KeyboardReturn)
            {
                case KeyboardReturnTypes.Default:
                case KeyboardReturnTypes.Done:
                    Control.SetImeActionLabel(extendedEntry.KeyboardReturn.ToString(), Android.Views.InputMethods.ImeAction.Done);
                    break;
                case KeyboardReturnTypes.Go:
                    Control.SetImeActionLabel(extendedEntry.KeyboardReturn.ToString(), Android.Views.InputMethods.ImeAction.Go);
                    break;
                case KeyboardReturnTypes.Next:
                case KeyboardReturnTypes.Continue:
                    Control.SetImeActionLabel(extendedEntry.KeyboardReturn.ToString(), Android.Views.InputMethods.ImeAction.Next);
                    break;
                case KeyboardReturnTypes.Search:
                    Control.SetImeActionLabel(extendedEntry.KeyboardReturn.ToString(), Android.Views.InputMethods.ImeAction.Search);
                    break;
                case KeyboardReturnTypes.Send:
                    Control.SetImeActionLabel(extendedEntry.KeyboardReturn.ToString(), Android.Views.InputMethods.ImeAction.Send);
                    break;
                case KeyboardReturnTypes.Google:
                case KeyboardReturnTypes.Join:
                case KeyboardReturnTypes.Route:
                case KeyboardReturnTypes.Yahoo:
                case KeyboardReturnTypes.EmergencyCall:
                    break;

            }
            if (e.NewElement != null && e.NewElement.FontFamily != null)
            {
                var FontFamily = e.NewElement.FontFamily;

                Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Fonts/" + FontFamily + ".ttf");
                Control.Typeface = font;
            }
            Control.SetPaddingRelative(extendedEntry.BorderRadius, 25, extendedEntry.BorderRadius, 15 );
        }    
        public override Drawable Background
        {
            get
            {
                return base.Background;
            }
            set
            {
                var extendedEntry = (ExtendedEntry)this.Element;
				GradientDrawable layer1 = new GradientDrawable();
				layer1.SetShape(ShapeType.Rectangle);
				layer1.SetCornerRadius(ConvertPixelstoDp(extendedEntry.BorderRadius));
                layer1.SetColor(extendedEntry.BackgroundColor.ToAndroid());   
                if (extendedEntry.BorderWidth > 0)
                    layer1.SetStroke(extendedEntry.BorderWidth,extendedEntry.BorderColor.ToAndroid());
                
				LayerDrawable layerDrawable = new LayerDrawable(new Drawable[] { layer1 });
                base.Background = layerDrawable;
            }
        }

        private float ConvertPixelstoDp(float pixelInput)
        {
            float outputVal = 0.0f;
            //if (pixelInput > (float)(this.Element.HeightRequest / 2))
                //pixelInput = (float)(this.Element.HeightRequest / 2);
               
            outputVal =  pixelInput * (int)Resources.System.DisplayMetrics.Density;
            return outputVal;
        }
    }
}
