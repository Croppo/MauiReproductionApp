using CommunityToolkit.Maui.Views;

namespace MauiTabbedApp
{
    public partial class AddModalView : ContentPage
    {
        public AddModalView(AddModalViewModel viewModelBase)
        {
            InitializeComponent();

            this.BindingContext = viewModelBase;
        }
    }
}