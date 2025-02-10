namespace MauiTabbedApp.Services
{
	public interface INavigationService
	{ 
		Task NavigateToAsync<TViewModel>(Dictionary<string, object> parameters = null) where TViewModel : ViewModelBase;

		Task NavigateToRootAsync<TViewModel>(Dictionary<string, object> parameters = null) where TViewModel : ViewModelBase;
	}
}