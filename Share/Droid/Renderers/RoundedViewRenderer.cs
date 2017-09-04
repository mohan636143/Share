using Android.Graphics.Drawables;
using Share.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content.Res;
using Share.Controls;

[assembly: ExportRenderer(typeof(RoundedView), typeof(RoundedViewRenderer))]
namespace Share.Droid.Renderers
{
    public class RoundedViewRenderer : ViewRenderer
    {

        RoundedView view = null;

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
			if (this.Element == null)
				return;
            base.OnElementChanged(e);
            view = (RoundedView)this.Element;
            //base.SetPaddingRelative(0,0,0,0);

        }

		public override Drawable Background
		{
			get
			{
				return base.Background;
			}
			set
			{
                view = (RoundedView)this.Element;
				GradientDrawable layer1 = new GradientDrawable();
				layer1.SetShape(ShapeType.Rectangle);
                layer1.SetCornerRadius(ConvertPixelstoDp(view.BorderRadius));
                layer1.SetColor(view.BackgroundColor.ToAndroid());
                if (view.BorderThickness > 0)
                    layer1.SetStroke(view.BorderThickness,view.BorderColor.ToAndroid());

				LayerDrawable layerDrawable = new LayerDrawable(new Drawable[] { layer1 });
                base.Background = layerDrawable;
			}
		}

        //public override void SetPadding(int left, int top, int right, int bottom)
        //{
        //    base.SetPadding(0,0,0,0);
        //}

		private float ConvertPixelstoDp(float pixelInput)
		{
			float outputVal = 0.0f;
			//if (pixelInput > (float)(this.Element.HeightRequest / 2))
			//	pixelInput = (float)(this.Element.HeightRequest / 2);

			outputVal = pixelInput * (int)Resources.System.DisplayMetrics.Density;
			return outputVal;
		}

    }
}
