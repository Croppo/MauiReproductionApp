namespace MauiTabbedApp;

public partial class MainPageView : TabbedPage
{
    public MainPageView(MainPageViewModel viewModel)
    {
        InitializeComponent();

        this.BindingContext = viewModel;
        
        (this.BindingContext as MainPageViewModel)?.Tabs.ForEach(this.Children.Add);
    }
}