namespace MauiTabbedApp.Services
{
	public class ViewBaseService : IViewBaseService
	{
		/// <inheritdoc/>
		public INavigationService NavigationService { get; }

		/// <inheritdoc/>
		public IThreadService ThreadService { get; }

		/// <inheritdoc/>
		public IPageService PageService { get; }

		public ViewBaseService(
			INavigationService navigationService,
			IThreadService threadService,
			IPageService pageService)
		{
			this.NavigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
			this.ThreadService = threadService ?? throw new ArgumentNullException(nameof(threadService));
			this.PageService = pageService ?? throw new ArgumentNullException(nameof(pageService));
		}
	}
}