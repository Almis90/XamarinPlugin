using Android.Content;
using Android.Runtime;
using Android.Views;

namespace XamarinPlugin
{
    public class DeviceOrientationImplementation : IDeviceOrientation
    {
        public Orientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 ||
                orientation == SurfaceOrientation.Rotation270;
            return isLandscape ? Orientation.Landscape : Orientation.Portrait;
        }
    }
}
