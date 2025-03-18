using MauiTabbedApp.Services.Navigation;

namespace MauiTabbedApp;

public partial class App : Application
{
    public App(MainPageViewModel tabbedPage)
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPageView(tabbedPage));
    }
}