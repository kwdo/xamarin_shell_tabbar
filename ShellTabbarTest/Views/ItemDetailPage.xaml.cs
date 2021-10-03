using System.ComponentModel;
using Xamarin.Forms;
using ShellTabbarTest.ViewModels;

namespace ShellTabbarTest.Views
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
