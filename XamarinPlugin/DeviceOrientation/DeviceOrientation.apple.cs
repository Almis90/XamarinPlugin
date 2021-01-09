using UIKit;

namespace XamarinPlugin
{
    public class DeviceOrientationImplementation : IDeviceOrientation
    {
        public Orientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? Orientation.Portrait : Orientation.Landscape;
        }
    }
}
