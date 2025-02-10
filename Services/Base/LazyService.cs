using MauiTabbedApp.Utilities;

namespace MauiTabbedApp.Services
{
	/// <summary>
	/// Implements an instance of the <see cref="ILazyService"/>.
	/// </summary>
	public class LazyService : ILazyService
	{
		/// <inheritdoc/>
		public T Resolve<T>() where T : class
			=> ServiceResolver.Resolve<T>();
	}
}