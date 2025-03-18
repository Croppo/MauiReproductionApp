using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;

namespace MauiTabbedApp
{
    public partial class HomeView : ContentPage
    {
        public HomeView(HomeViewModel viewModelBase)
        {
            InitializeComponent();

            this.BindingContext = viewModelBase;
        }
    }
}