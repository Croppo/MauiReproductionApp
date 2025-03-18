namespace MauiTabbedApp.Services.Navigation;

public class NavigationService : INavigationService
{
    private readonly IServiceProvider _serviceProvider;
    
    public NavigationService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public Task PushAsync<TPage>() where TPage : Page
    {
        var page = ResolvePage<TPage>();
        
        if (Application.Current?.MainPage?.Navigation != null)
            return Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(page));
        
        return Task.CompletedTask;
    }
    
    public Task PopAsync()
    {
        if (Application.Current?.MainPage?.Navigation != null)
            return Application.Current.MainPage.Navigation.PopAsync();
        
        return Task.CompletedTask;
    }
    
    public Task PushModalAsync<TPage>() where TPage : Page
    {
        var page = ResolvePage<TPage>();
        
        if (Application.Current?.MainPage?.Navigation != null)
            return Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(page));
        
        return Task.CompletedTask;
    }
    
    public Task PopModalAsync()
    {
        if (Application.Current?.MainPage?.Navigation != null)
            return Application.Current.MainPage.Navigation.PopModalAsync();
        
        return Task.CompletedTask;
    }
    
    private TPage ResolvePage<TPage>() where TPage : Page
    {
        // This will create the page and inject all its dependencies
        return _serviceProvider.GetRequiredService<TPage>();
    }
}