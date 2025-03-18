namespace MauiTabbedApp
{

    public partial class ContactPermissionsView : ContentPage
    {
        public ContactPermissionsView(ContactPermissionsViewModel viewModelBase)
        {
            InitializeComponent();

            this.BindingContext = viewModelBase;
        }
    }
}