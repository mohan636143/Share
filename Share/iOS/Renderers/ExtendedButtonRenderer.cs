using System;
using Share.Controls;
using Share.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]
namespace Share.iOS
{
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            if (this.Element == null)
                return;
            ExtendedButton extendedButton = (ExtendedButton)this.Element;
            base.OnElementChanged(e);

			if (extendedButton.BorderWidth > 0)
			{
				Control.Layer.BorderWidth = (nfloat)extendedButton.BorderWidth;
                Control.Layer.BorderColor = extendedButton.BorderColor.ToCGColor();
				//if (extendedButton.BorderRadius < extendedButton.HeightRequest)
					Control.Layer.CornerRadius = (nfloat)extendedButton.BorderRadius;
				//else
				//	Control.Layer.CornerRadius = (nfloat)(extendedButton.HeightRequest / 2);
			}
        }
    }
}
