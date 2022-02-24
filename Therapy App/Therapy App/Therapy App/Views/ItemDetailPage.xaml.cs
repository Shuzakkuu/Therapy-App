using System.ComponentModel;
using Therapy_App.ViewModels;
using Xamarin.Forms;

namespace Therapy_App.Views
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