namespace MauiTabbedApp.Services
{
	public interface IPageService
	{ 
		/// <summary>
		/// Gets or sets the root page of the application.
		/// </summary>
		Page? MainPage { get; set; }
		
		/// <summary>
		/// Gets the current navigation view.
		/// </summary>
		NavigationPage? CurrentNavigationView { get; }

		Page CreatePage<TViewModel>() where TViewModel : ViewModelBase;
	}
}