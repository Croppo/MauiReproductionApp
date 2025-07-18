using CommunityToolkit.Maui.Views;

namespace MauiTabbedApp
{
    public partial class NavigateToRootModalView : ContentPage
    {
        public NavigateToRootModalView(NavigateToRootModalViewModel viewModelBase)
        {
            InitializeComponent();

            this.BindingContext = viewModelBase;
        }
    }
}