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
		
		
		[RelayCommand]
		public void OpenNavigateToRootModal()
		{
			this.navigationService.PushAsync<NavigateToRootModalView>();
		}
		
		[RelayCommand]
		public async Task OpenCollectionView()
		{
			await this.navigationService.PushAsync<CollectionViewOrientationView>();
		}
		
		[RelayCommand]
		public async Task OpenActionSheet()
		{
			var options = Enumerable.Range(1, 20).Select(i => $"Option {i}").ToArray();

			var result = await Application.Current?.MainPage.DisplayActionSheet(
				"Choose an Option", "Cancel", null, options);
		}
	}
}