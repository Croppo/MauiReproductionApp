using CommunityToolkit.Mvvm.Input;
using MauiTabbedApp.Services.Navigation;

namespace MauiTabbedApp
{
	public partial class NavigateToRootModalViewModel : ViewModelBase
	{
		private readonly INavigationService _navigationService;

		public NavigateToRootModalViewModel(INavigationService navigationService)
		{
			this._navigationService = navigationService;
		}

		[RelayCommand]
		public async Task ClosePopup()
		{
			await this._navigationService.PopModalAsync();
		}
		
		[RelayCommand]
		public async Task ReturnToRoot()
		{
			await this._navigationService.NavigateToRootAsync();
		}
	}
}