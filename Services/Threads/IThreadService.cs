namespace MauiTabbedApp.Services;

public interface IThreadService
{
    void InvokeOnMainThread(Action action);

    Task InvokeOnMainThreadAsync(Action action);

    Task<T> InvokeOnMainThreadAsync<T>(Func<T> action);

    Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> action);

    Task Delay(int milliseconds, CancellationToken cancellationToken = default);
}