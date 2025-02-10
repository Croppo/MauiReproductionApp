namespace MauiTabbedApp.Services;

public class ThreadService : IThreadService
{
    /// <inheritdoc/>
    public void InvokeOnMainThread(Action action)
    {
        MainThread.BeginInvokeOnMainThread(action);
    }

    /// <inheritdoc/>
    public Task InvokeOnMainThreadAsync(Action action)
    {
        return MainThread.InvokeOnMainThreadAsync(action);
    }

    /// <inheritdoc/>
    public async Task<T> InvokeOnMainThreadAsync<T>(Func<T> action)
    {
        return await MainThread.InvokeOnMainThreadAsync(action);
    }

    /// <inheritdoc/>
    public async Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> action)
    {
        return await MainThread.InvokeOnMainThreadAsync(action);
    }
    
    public async Task Delay(int milliseconds, CancellationToken cancellationToken = default)
    {
        await Task.Delay(milliseconds, cancellationToken);
    }
}