using System.Globalization;
using System.Reflection;
using MauiTabbedApp.Services.App;

namespace MauiTabbedApp.Services
{
	public class PageService : IPageService
	{
		private readonly ILazyService lazyService;
		public PageService(ILazyService lazyService)
		{
			this.lazyService = lazyService;
		}
		
		/// <inheritdoc/>
		/// <inheritdoc/>
		public Page MainPage
		{
			get => this.lazyService.Resolve<IApp>().Get()?.MainPage;
			set => this.lazyService.Resolve<IApp>().Get().MainPage = value;
		}
		// TODO: this is not getting main page now its using lazy service

		/// <inheritdoc/>
		public NavigationPage? CurrentNavigationView
		{
			get
			{
				var page = Application.Current?.MainPage;

				return page as NavigationPage;
			}
		}
		
		/// <inheritdoc/>
		public Page CreatePage<TViewModel>() 
			where TViewModel : ViewModelBase
		{
			// Get the corresponding page type for the given ViewModel
			var pageType = this.GetPageTypeForViewModel<TViewModel>();
    
			if (pageType == null)
			{
				throw new InvalidOperationException($"No page found for ViewModel type {typeof(TViewModel).Name}");
			}

			// Resolve the necessary dependencies
			var viewModel = this.lazyService.Resolve<TViewModel>();
			var viewBaseService = this.lazyService.Resolve<IViewBaseService>();

			// Check if the ViewModel was resolved successfully
			if (viewModel == null)
			{
				throw new InvalidOperationException($"Failed to resolve ViewModel of type {typeof(TViewModel).Name}");
			}

			// Create the page instance dynamically
			var page = Activator.CreateInstance(pageType, viewModel, viewBaseService) as Page;
			
			// TODO this activator is causing crash

			// Handle failure to create the page
			if (page == null)
			{
				throw new InvalidOperationException($"Failed to create an instance of {pageType.Name}");
			}

			return page;
		}
		
		
		private Type GetPageTypeForViewModel<TViewModel>()
			where TViewModel : ViewModelBase
		{
			var viewName = typeof(TViewModel).FullName.Replace("Model", string.Empty);
			var viewModelAssemblyName = typeof(TViewModel).GetTypeInfo().Assembly.FullName;
			var viewAssemblyName = string.Format(CultureInfo.InvariantCulture, "{0}, {1}", viewName, viewModelAssemblyName);
			var viewType = Type.GetType(viewAssemblyName);

			if (viewType is null)
			{
				var exception = new Exception("Could not get the view type.");

				throw exception;
			}

			return viewType;
		}
	}
}