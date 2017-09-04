using System;
using System.Collections.Generic;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms;
using Share.Views;

namespace Share
{
    public partial class MapPage : ContentPage
    {

        #region Public Properties

        Position CurrentPosition;
        Distance CurrentScale;

        #endregion Public Properties


        public MapPage()
        {
            InitializeComponent();
            CurrentPosition = new Position(12.9539974, 77.6309395);
            //CurrentPosition = new Position(12.932597, 77.614145);
            CurrentScale = new Distance(500.0);
            (inMap as Map).MoveToRegion(new MapSpan(CurrentPosition, 0.01, 0.01));
            //(inMap as Map).MoveToRegion(new MapSpan(CurrentPosition, 0.005, 0.005));
            inMap.MyLocationButtonClicked += SetToCurrentLocation;
        }

        void SetToCurrentLocation(object sender, EventArgs e)
        {
            CurrentPosition = new Position(12.932597, 77.614145);
            if (Device.OS == TargetPlatform.iOS)
                return;
            (inMap as Map).MoveToRegion(new MapSpan(CurrentPosition, 0.005, 0.005));

            //Circle c = new Circle();
            //c.Center = CurrentPosition;
            //c.Radius = CurrentScale;

            //c.FillColor = Color.LightBlue;
            //c.StrokeColor = Color.Blue;
            //c.StrokeWidth = 1.0f;

            //inMap.Circles.Add(c);
        }

    }
}
