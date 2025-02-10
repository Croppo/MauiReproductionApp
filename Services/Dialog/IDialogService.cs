namespace MauiTabbedApp.Services
{
	public interface IDialogService
	{ 
		Task DisplayActionSheet(string title, string cancel, string destruction, params string[] buttons);
	}
}