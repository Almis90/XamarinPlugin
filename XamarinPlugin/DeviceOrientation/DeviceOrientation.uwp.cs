using Windows.UI.ViewManagement;

namespace XamarinPlugin
{
    public class DeviceOrientationImplementation : IDeviceOrientation
    {
        public Orientation GetOrientation()
        {
            ApplicationViewOrientation orientation = ApplicationView.GetForCurrentView().Orientation;
            return orientation == ApplicationViewOrientation.Landscape ? Orientation.Landscape : Orientation.Portrait;
        }
    }
}
