namespace MauiTabbedApp.Services
{
	/// <summary>
	/// A service for resolving services in-line.
	/// </summary>
	public interface ILazyService
	{
		/// <summary>
		/// Resolves the object from the container.
		/// </summary>
		/// <typeparam name="T">The type of class.</typeparam>
		/// <returns>The registered class.</returns>
		public T Resolve<T>() where T: class;
	}
}