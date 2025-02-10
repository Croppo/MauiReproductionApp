namespace MauiTabbedApp
{

    public partial class AccountView : ContentPage
    {
        public AccountView(AccountViewModel viewModelBase)
        {
            InitializeComponent();

            this.BindingContext = viewModelBase;
        }
    }
}