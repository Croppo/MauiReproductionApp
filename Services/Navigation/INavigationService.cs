namespace MauiTabbedApp.Services.Navigation;

public interface INavigationService
{
    Task PushAsync<TPage>() where TPage : Page;
    Task  PopAsync();
    Task  PushModalAsync<TPage>() where TPage : Page;
    Task  PopModalAsync();
}