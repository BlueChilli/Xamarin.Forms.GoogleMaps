﻿
using System;

namespace Xamarin.Forms.GoogleMaps.Logics.iOS
{
    internal sealed class UiSettingsLogic : BaseUiSettingsLogic<Google.Maps.MapView>
    {
        protected override void OnUpdateCompassEnabled()
        {
            NativeMap.Settings.CompassButton = Map.UiSettings.CompassEnabled;
        }

        protected override void OnUpdateRotateGesturesEnabled()
        {
            NativeMap.Settings.RotateGestures = Map.UiSettings.RotateGesturesEnabled;

            if (Map.HasRotationEnabled != Map.UiSettings.RotateGesturesEnabled)
            {
                Map.HasRotationEnabled = Map.UiSettings.RotateGesturesEnabled;
            }
        }

        protected override void OnUpdateMyLocationButtonEnabled()
        {
            NativeMap.Settings.MyLocationButton = Map.UiSettings.MyLocationButtonEnabled;
        }

        protected override void OnUpdateIndoorLevelPickerEnabled()
        {
            NativeMap.Settings.IndoorPicker = Map.UiSettings.IndoorLevelPickerEnabled;
        }

        protected override void OnUpdateScrollGesturesEnabled()
        {
            NativeMap.Settings.ScrollGestures = Map.UiSettings.ScrollGesturesEnabled;

            if (Map.HasScrollEnabled != Map.UiSettings.ScrollGesturesEnabled)
            {
                Map.HasScrollEnabled = Map.UiSettings.ScrollGesturesEnabled;
            }
        }

        protected override void OnUpdateTiltGesturesEnabled()
        {
            NativeMap.Settings.TiltGestures = Map.UiSettings.TiltGesturesEnabled;
        }

        protected override void OnUpdateZoomControlsEnabled()
        {
        }

        protected override void OnUpdateZoomGesturesEnabled()
        {
            NativeMap.Settings.ZoomGestures = Map.UiSettings.ZoomGesturesEnabled;
        }
    }
}