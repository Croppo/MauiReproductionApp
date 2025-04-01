using CommunityToolkit.Maui.Views;

namespace MauiTabbedApp
{
    public partial class CollectionViewOrientationView : ContentPage
    {
        public CollectionViewOrientationView(CollectionViewOrientationViewModel viewModelBase)
        {
            InitializeComponent();

            this.BindingContext = viewModelBase;
        }
    }
}