namespace MauiTabbedApp
{

    public partial class ReproHistoryView : ContentPage
    {
        public ReproHistoryView(ReproHistoryViewModel viewModel)
        {
            InitializeComponent();

            this.BindingContext = viewModel;
        }
    }
}