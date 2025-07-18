using MauiTabbedApp.Models;
using MauiTabbedApp.Services.Navigation;

namespace MauiTabbedApp
{
	public partial class CollectionViewOrientationViewModel : ViewModelBase
	{
		public CollectionViewOrientationViewModel(INavigationService navigationService)
		{
			// Hardcoded data
			Items = new List<SimpleItem>
			{
				new SimpleItem { Name = "Laptop", Price = 999.99m },
				new SimpleItem { Name = "Phone", Price = 499.99m },
				new SimpleItem { Name = "Headphones", Price = 99.99m },
				new SimpleItem { Name = "Tablet", Price = 399.99m },
				new SimpleItem { Name = "Smart Watch", Price = 199.99m },
				new SimpleItem { Name = "Camera", Price = 599.99m },
				new SimpleItem { Name = "Laptop", Price = 999.99m },
				new SimpleItem { Name = "Phone", Price = 499.99m },
				new SimpleItem { Name = "Headphones", Price = 99.99m },
				new SimpleItem { Name = "Tablet", Price = 399.99m },
				new SimpleItem { Name = "Smart Watch", Price = 199.99m },
				new SimpleItem { Name = "Camera", Price = 599.99m },
				new SimpleItem { Name = "Laptop", Price = 999.99m },
				new SimpleItem { Name = "Phone", Price = 499.99m },
				new SimpleItem { Name = "Headphones", Price = 99.99m },
				new SimpleItem { Name = "Tablet", Price = 399.99m },
				new SimpleItem { Name = "Smart Watch", Price = 199.99m },
				new SimpleItem { Name = "Camera", Price = 599.99m },
				new SimpleItem { Name = "Laptop", Price = 999.99m },
				new SimpleItem { Name = "Phone", Price = 499.99m },
				new SimpleItem { Name = "Headphones", Price = 99.99m },
				new SimpleItem { Name = "Tablet", Price = 399.99m },
				new SimpleItem { Name = "Smart Watch", Price = 199.99m },
				new SimpleItem { Name = "Camera", Price = 599.99m },
				new SimpleItem { Name = "Laptop", Price = 999.99m },
				new SimpleItem { Name = "Phone", Price = 499.99m },
				new SimpleItem { Name = "Headphones", Price = 99.99m },
				new SimpleItem { Name = "Tablet", Price = 399.99m },
				new SimpleItem { Name = "Smart Watch", Price = 199.99m },
				new SimpleItem { Name = "Camera", Price = 599.99m },
				new SimpleItem { Name = "Laptop", Price = 999.99m },
				new SimpleItem { Name = "Phone", Price = 499.99m },
				new SimpleItem { Name = "Headphones", Price = 99.99m },
				new SimpleItem { Name = "Tablet", Price = 399.99m },
				new SimpleItem { Name = "Smart Watch", Price = 199.99m },
				new SimpleItem { Name = "Camera", Price = 599.99m },
				new SimpleItem { Name = "Laptop", Price = 999.99m },
				new SimpleItem { Name = "Phone", Price = 499.99m },
				new SimpleItem { Name = "Headphones", Price = 99.99m },
				new SimpleItem { Name = "Tablet", Price = 399.99m },
				new SimpleItem { Name = "Smart Watch", Price = 199.99m },
				new SimpleItem { Name = "Camera", Price = 599.99m }
			};
		}

		public List<SimpleItem> Items { get; set; }
	}
}
