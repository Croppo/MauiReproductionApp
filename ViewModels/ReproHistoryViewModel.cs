using CommunityToolkit.Mvvm.Input;
using MauiTabbedApp.Services.Navigation;

namespace MauiTabbedApp
{
	public partial class ReproHistoryViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		public ReproHistoryViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}

		[RelayCommand]
		public async Task NavigateToContactPermissions()
		{
			await this.navigationService.PushAsync<ContactPermissionsView>();
		}
		
		[RelayCommand]
		public async Task NavigateToOpenModal()
		{
			await this.navigationService.PushAsync<AddModalView>();
		}
	}
}