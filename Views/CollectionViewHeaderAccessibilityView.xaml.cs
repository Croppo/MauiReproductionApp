using CommunityToolkit.Maui.Views;

namespace MauiTabbedApp
{
    public partial class CollectionViewHeaderAccessibilityView : ContentPage
    {
        public CollectionViewHeaderAccessibilityView(CollectionViewHeaderAccessibilityViewModel viewModelBase)
        {
            InitializeComponent();

            this.BindingContext = viewModelBase;
        }
    }
}