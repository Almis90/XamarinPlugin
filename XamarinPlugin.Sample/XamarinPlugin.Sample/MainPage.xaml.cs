using Xamarin.Forms;

namespace XamarinPlugin.Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (DeviceOrientation.IsSupported)
            {
                OrientationSpan.Text = DeviceOrientation.Current.GetOrientation().ToString();
            }
            else
            {
                OrientationSpan.Text = "Unknown";
            }
        }
    }
}
