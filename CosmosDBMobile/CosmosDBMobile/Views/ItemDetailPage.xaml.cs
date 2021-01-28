using CosmosDBMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CosmosDBMobile.Views
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