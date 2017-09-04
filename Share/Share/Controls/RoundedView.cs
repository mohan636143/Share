using System;
using Xamarin.Forms;
namespace Share.Controls
{
    public class RoundedView : Grid
    {

		#region CornerRadius

		public static BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(BorderRadius), typeof(float), 
                                                                                     typeof(RoundedView), defaultValue: 0.0f);

        public float BorderRadius
        {
            get 
            { 
                return (float)GetValue(CornerRadiusProperty); 
            }
            set
            {
                SetValue(CornerRadiusProperty, value);
            }
        }

		#endregion CornerRadius

		#region BorderThickness

        public static BindableProperty BorderThicknessProperty = BindableProperty.Create(nameof(BorderThickness), typeof(int),
																					 typeof(RoundedView), defaultValue: 0);
		public int BorderThickness
		{
			get
			{
				return (int)GetValue(BorderThicknessProperty);
			}
			set
			{
                SetValue(BorderThicknessProperty, value);
			}
		}

		#endregion BorderThickness

		#region BorderColor

        public static BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color),
                                                                                     typeof(RoundedView), defaultValue: Color.Transparent,
                                                                                     propertyChanged:OnBorderColorPropertyChanged);
		public Color BorderColor
		{
			get
			{
				return (Color)GetValue(BorderColorProperty);
			}
			set
			{
				SetValue(BorderColorProperty, value);
			}
		}

        public static void OnBorderColorPropertyChanged(BindableObject bindable,object oldValue,object newValue)
        {
            
        }

		#endregion BorderColor
    }
}
