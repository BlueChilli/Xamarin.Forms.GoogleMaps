using System;
namespace Xamarin.Forms.GoogleMaps.Internals
{
    class GetPointMessage
    {
        public Action<Point> OnGetPoint { get; }

        public Pin Pin { get; }

        public GetPointMessage(Action<Point> onGetPoint, Pin pin)
        {
            OnGetPoint = onGetPoint;
            Pin = pin;
        }
    }
}
