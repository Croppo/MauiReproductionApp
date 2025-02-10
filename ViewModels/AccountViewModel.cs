using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTabbedApp.Services;

namespace MauiTabbedApp
{
	public partial class AccountViewModel : ObservableObject
	{
		private readonly IContacts contacts;

		[ObservableProperty] 
		private string permissionStatus = "Unset";
		
		[ObservableProperty] 
		private bool canOpenContacts = false;
		
		[ObservableProperty] 
		private Color permissionTextColor = Colors.Grey;

		public AccountViewModel(IContacts contacts)
		{
			this.contacts = contacts;
		}

		[RelayCommand]
		private async Task CheckPermissions()
		{
			try
			{
				var status = await Permissions.RequestAsync<Permissions.ContactsRead>();
				
				this.PermissionStatus = status.ToString();

				if (status == Microsoft.Maui.ApplicationModel.PermissionStatus.Granted)
				{
					this.PermissionTextColor = Colors.Green;

					this.CanOpenContacts = true;
					
					return;
				}
				else if (status == Microsoft.Maui.ApplicationModel.PermissionStatus.Unknown || status == Microsoft.Maui.ApplicationModel.PermissionStatus.Denied)
				{
					this.PermissionTextColor = Colors.Red;
				}
				else if (status == Microsoft.Maui.ApplicationModel.PermissionStatus.Limited)
				{
					this.PermissionTextColor = Colors.Pink;
				}
				else
				{
					this.PermissionTextColor = Colors.Black;
				}

				this.CanOpenContacts = false;
			}
			catch (Exception ex)
			{
				// Log the error and update the status with the error message
				Console.WriteLine($"Error checking/asking for permission: {ex.Message}");
				this.PermissionStatus = $"Error: {ex.Message}";
			}
		}
		
		[RelayCommand]
		private async Task OpenContacts()
		{
			try
			{
				var status = await Permissions.RequestAsync<Permissions.ContactsRead>();
				
				var contact = await this.contacts.PickContactAsync();
				
				if (contact is null)
				{
					return;
				}
			}
			catch (Exception ex)
			{
				// Log the error and update the status with the error message
				Console.WriteLine($"Error checking/asking for permission: {ex.Message}");
				this.PermissionStatus = $"Error: {ex.Message}";
			}
		}
	}
}