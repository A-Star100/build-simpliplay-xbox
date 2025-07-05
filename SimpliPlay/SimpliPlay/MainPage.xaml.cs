using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace SimpliPlay
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadLocalHtml();
        }

        private async void LoadLocalHtml()
        {
            var folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var file = await folder.GetFileAsync(@"WebAssets\index.html");
            var uri = new System.Uri($"ms-appx-web:///{file.Path.Replace('\\','/')}");
            MyWebView.Navigate(uri);
        }
    }
}
