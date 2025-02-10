using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTabbedApp
{
	public partial class TabbedPageViewModel : ObservableObject
	{
		private List<Page> tabs;

        private readonly AccountViewModel accountViewModel;

        public TabbedPageViewModel(AccountViewModel accountViewModel)
        {
	        this.accountViewModel = accountViewModel;
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
			var navPage1 = new NavigationPage(new AccountView(this.accountViewModel))
			{
				Title = "Contact Permissions"
			};

			this.tabs = new List<Page>
			{
				navPage1
			};
		}
	}
}