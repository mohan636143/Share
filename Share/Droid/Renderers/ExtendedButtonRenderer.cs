

using Android.Views;
using Share.Controls;
using Share.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Content.Res;

[assembly: ExportRenderer(typeof (ExtendedButton), typeof (ExtendedButtonRenderer))]
namespace Share.Droid
{
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button>e)
        {
			if (this.Element == null)
				return;
			base.OnElementChanged(e);
			//ExtendedButton eButton = (ExtendedButton)this.Element;
			//eButton.BorderWidth = 2.0;
			//eButton.BorderColor = Xamarin.Forms.Color.Black;
			//eButton.BorderRadius = 40;



			//Control.SetBackgroundColor(eButton.BackgroundColor.ToAndroid());
			//Control.SetBackgroundResource(Resource.Layout.ExtendedEntryBG);
			//Android.Views.View tmp = FindViewById(Resource.Id.bgSolidColor);
			//Android.Views.View ctr = LayoutInflater.From(Forms.Context).Inflate(Resource.Layout.ExtendedEntryBG, null, false);


			//GradientDrawable layer1 = new GradientDrawable();
			////RoundRectShape rectShape = new RoundRectShape(new float[] { 7.0f },, new float[] { 7.0f });
			
			//layer1.SetShape(ShapeType.Rectangle);
			//layer1.SetCornerRadius(80.0f);
			//layer1.SetColor(Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.DarkRed));
   //         //layer1.SetStroke(4, Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.DarkGreen));
			////// This is your second item in your XML file
			//////GradientDrawable layer2 = new GradientDrawable();
			//////layer2.setShape(GradientDrawable.RECTANGLE);
			//////layer2.setColor(Color.parseColor("#d7ffa2"));
			////// This will give the bottom space which you are unable to do    
			//////InsetDrawable insetLayer2 = new InsetDrawable(layer2, 0, 0, 0, 2);
			////// This is the final drawable which is to be used
			//LayerDrawable layerDrawable = new LayerDrawable(new Drawable[] { layer1 });
			//Control.SetBackground(layerDrawable);



        }

        public override Drawable Background
        {
            get
            {
                return base.Background;
            }
            set
            {
				var extendedButton = (ExtendedButton)this.Element;
				GradientDrawable layer1 = new GradientDrawable();
				layer1.SetShape(ShapeType.Rectangle);
				layer1.SetCornerRadius(ConvertPixelstoDp(extendedButton.BorderRadius));
                layer1.SetColor(extendedButton.BackgroundColor.ToAndroid());
                if (extendedButton.BorderWidth > 0)
                                layer1.SetStroke((int)extendedButton.BorderWidth,extendedButton.BorderColor.ToAndroid());

				LayerDrawable layerDrawable = new LayerDrawable(new Drawable[] { layer1 });
				base.Background = layerDrawable;
            }
        }

		private float ConvertPixelstoDp(float pixelInput)
		{
			float outputVal = 0.0f;
			if (pixelInput > (float)(this.Element.HeightRequest / 2))
				pixelInput = (float)(this.Element.HeightRequest / 2);

            outputVal = pixelInput * (int)Resources.System.DisplayMetrics.Density;
			return outputVal;
		}

    }
}
