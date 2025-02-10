namespace MauiTabbedApp;

public partial class MainPage : TabbedPage
{
    public MainPage(TabbedPageViewModel viewModel)
    {
        InitializeComponent();

        this.BindingContext = viewModel;
        
        (this.BindingContext as TabbedPageViewModel)?.Tabs.ForEach(this.Children.Add);
    }
}