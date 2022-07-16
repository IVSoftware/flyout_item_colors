using flyout_item_colors.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace flyout_item_colors.Views
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