namespace MauiTabbedApp.Services;

public interface IViewBaseService
{
    /// <summary>
    /// Gets or sets the messaging service.
    /// </summary>
    INavigationService NavigationService { get; }

    /// <summary>
    /// Gets or sets the thread service.
    /// </summary>
    IThreadService ThreadService { get; }

    /// <summary>
    /// Gets or sets the page service.
    /// </summary>
    IPageService PageService { get; }
}