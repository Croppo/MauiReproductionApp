namespace MauiTabbedApp.Services
{
	public class DialogService : IDialogService
	{
		public async Task DisplayActionSheet(string title, string cancel, string destruction, params string[] buttons)
		{
			var currentPage = Application.Current?.MainPage;
			await currentPage?.DisplayActionSheet(title, cancel, destruction, buttons)!;
		}
	}
}