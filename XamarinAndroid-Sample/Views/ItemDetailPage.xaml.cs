using System.ComponentModel;
using Xamarin.Forms;
using XamarinAndroid_Sample.ViewModels;

namespace XamarinAndroid_Sample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}