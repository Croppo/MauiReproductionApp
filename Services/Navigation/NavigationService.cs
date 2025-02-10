namespace MauiTabbedApp.Services
{
	public class NavigationService : INavigationService
	{
		private readonly IPageService _pageService;
		private readonly IThreadService _threadService;

		public NavigationService(IPageService pageService, IThreadService threadService)
		{
			_pageService = pageService;
			_threadService = threadService;
		}
		
		public async Task NavigateToAsync<TViewModel>(Dictionary<string, object> parameters = null) 
			where TViewModel : ViewModelBase
		{
			parameters ??= [];
			
			var page = await this.CreatePageIfMainIsNotNull<TViewModel>(parameters);

			this._threadService.InvokeOnMainThreadAsync(async () =>
			{
				await this._pageService.CurrentNavigationView.Navigation.PushAsync(page);
			});
		}
		
		/// <inheritdoc/>
		public async Task NavigateToRootAsync<TViewModel>(Dictionary<string, object> parameters = null) 
			where TViewModel : ViewModelBase
		{
			parameters ??= [];

			var page = await this._threadService.InvokeOnMainThreadAsync(() =>
			{
				return this._pageService.CreatePage<TViewModel>();
			});

			if (this._pageService.MainPage == null)
			{

				this._pageService.MainPage = new NavigationPage(page);
				
			}
			else
			{
				this._threadService.InvokeOnMainThread(() => this._pageService.MainPage = new NavigationPage(page));
			}
		}
		
		private async Task<Page> CreatePageIfMainIsNotNull<TViewModel>(Dictionary<string, object> parameters = null) where TViewModel : ViewModelBase
		{
			parameters ??= [];

			if (this._pageService.MainPage is null)
			{
				// The app has not been initialized.
				await this.NavigateToRootAsync<TViewModel>(parameters);

				return null;
			}

			return this._pageService.CreatePage<TViewModel>();
		}
	}
}