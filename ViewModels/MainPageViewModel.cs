using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTabbedApp
{
	public class MainPageViewModel : ObservableObject
	{
		private List<Page> tabs;

        private readonly HomeViewModel homeViewModel;
        private readonly ReproHistoryViewModel reproHistoryViewModel;

        public MainPageViewModel(HomeViewModel homeViewModel, ReproHistoryViewModel reproHistoryViewModel)
        {
	        this.homeViewModel = homeViewModel;
	        this.reproHistoryViewModel = reproHistoryViewModel;
        }

		/// <summary>
		/// Gets the list of tabs.
		/// </summary>
		public List<Page> Tabs
		{
			get
			{
				if (this.tabs == null || !this.tabs.Any())
				{
					this.CreateTabPages();
				}

				return this.tabs;
			}
		}

		/// <summary>
		/// Gets the tabs to display.
		/// </summary>
		private void CreateTabPages()
		{
			var navPage1 = new NavigationPage(new HomeView(this.homeViewModel))
			{
				Title = "Issue"
			};

			var navPage2 = new NavigationPage(new ReproHistoryView(this.reproHistoryViewModel))
			{
				Title = "History"
			};

			this.tabs = new List<Page>
			{
				navPage1,
				navPage2
			};
		}
	}
}