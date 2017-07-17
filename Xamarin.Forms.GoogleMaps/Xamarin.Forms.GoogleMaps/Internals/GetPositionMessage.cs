using System;
namespace Xamarin.Forms.GoogleMaps.Internals
{
    class GetPositionMessage
    {
        public Action<Position> OnGetPosition { get; }

        public Point Point { get; }

        public GetPositionMessage(Action<Position> onGetPoint, Point point)
        {
            OnGetPosition = onGetPoint;
            Point = point;
        }
    }
}
