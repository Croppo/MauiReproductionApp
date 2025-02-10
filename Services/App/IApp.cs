namespace MauiTabbedApp.Services.App
{

    public interface IApp
    {
        /// <summary>
        /// Gets the application context.
        /// </summary>
        /// <returns>The application context.</returns>
        Application Get();
    }
}