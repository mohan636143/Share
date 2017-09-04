using System;
using Share.Controls;
using Share.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedView), typeof(RoundedViewRenderer))]
namespace Share.iOS.Renderers
{
    public class RoundedViewRenderer : ViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<View> e)
		{
			if (this.Element == null)
				return;
            
			base.OnElementChanged(e);

            var roundedBtn = (RoundedView)this.Element;

            if (roundedBtn.BorderRadius > 0)
			{
                this.Layer.BorderWidth = (nfloat)roundedBtn.BorderThickness;
                this.Layer.BorderColor = roundedBtn.BorderColor.ToCGColor();
                //if (roundedBtn.BorderRadius < roundedBtn.HeightRequest)
                    this.Layer.CornerRadius = (nfloat)roundedBtn.BorderRadius;
				//else
                 //   this.Layer.CornerRadius = (nfloat)(roundedBtn.HeightRequest / 2);
			}
		}



	}
}
