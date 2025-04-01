using CommunityToolkit.Mvvm.Input;
using MauiTabbedApp.Services.Navigation;

namespace MauiTabbedApp
{
	public partial class HomeViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		public HomeViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}
		
		[RelayCommand]
		public async Task OpenCollectionView()
		{
			await this.navigationService.PushAsync<CollectionViewOrientationView>();
		}
	}
}