using CommunityToolkit.Mvvm.Input;
using MauiTabbedApp.Services.Navigation;

namespace MauiTabbedApp
{
	public partial class AddModalViewModel : ViewModelBase
	{
		private readonly INavigationService _navigationService;

		public AddModalViewModel(INavigationService navigationService)
		{
			this._navigationService = navigationService;
		}

		[RelayCommand]
		public async Task ClosePopup()
		{
			await this._navigationService.PopModalAsync();
		}
	}
}