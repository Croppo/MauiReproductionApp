using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MauiTabbedApp.Models;
using MauiTabbedApp.Services.Navigation;

namespace MauiTabbedApp
{
	public partial class CollectionViewHeaderAccessibilityViewModel : ViewModelBase
	{
		
		public List<SimpleItem> Items { get; set; }

		public ObservableCollection<GroupedCollection> GroupedItems { get; set; }
		
		public CollectionViewHeaderAccessibilityViewModel(INavigationService navigationService)
		{
			// Hardcoded data
			this.Items = new List<SimpleItem>
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
			
			// Group by first letter of Name
			var grouped = this.Items
				.GroupBy(i => i.Name[0].ToString().ToUpper())
				.OrderBy(g => g.Key)
				.Select(g =>
				{
					// Duplicate items in the group (2x)
					var doubled = g.Concat(g);
					// Duplicate again (4x total)
					var quadrupled = doubled.Concat(doubled).ToList();
					return new GroupedCollection(g.Key, quadrupled);
				})
				.ToList();
			
			this.GroupedItems = new ObservableCollection<GroupedCollection>(grouped);
		}

	}
}