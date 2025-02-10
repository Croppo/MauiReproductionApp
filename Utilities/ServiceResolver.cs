namespace MauiTabbedApp.Utilities
{
    /// <summary>
    /// Utility class for resolving services.
    /// </summary>
    public static class ServiceResolver
	{
		/// <summary>
		/// Resolves a service.
		/// </summary>
		public static TService Resolve<TService>()
            => (TService)IPlatformApplication.Current.Services.GetService(typeof(TService));
	}
}