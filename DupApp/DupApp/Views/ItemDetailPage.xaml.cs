using DupApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DupApp.Views
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