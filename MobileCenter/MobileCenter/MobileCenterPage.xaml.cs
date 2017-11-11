using Xamarin.Forms;

namespace MobileCenter
{
    public partial class MobileCenterPage : ContentPage
    {
        public MobileCenterPage()
        {
            InitializeComponent();

            BindingContext = new MobileCenterViewModel();
        }
    }
}
