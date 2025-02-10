namespace MauiTabbedApp.Services.App;

public class App : IApp
{
    private readonly Application app;

    public App(Application app)
    {
        this.app = app;
    }

    /// <inheritdoc/>
    public Application Get()
    {
        return this.app;
    }
}