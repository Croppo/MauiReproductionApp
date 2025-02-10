using MauiTabbedApp.Services;
using Microsoft.Extensions.Logging;
using Communication = Microsoft.Maui.ApplicationModel.Communication;

namespace MauiTabbedApp
{

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Register the ViewModel with DI containers
            builder.Services.AddSingleton<TabbedPageViewModel>();
            builder.Services.AddSingleton<ViewModelBase>();
            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddSingleton<AccountViewModel>();

            // Register the services with DI containers
            builder.Services.AddSingleton<IDialogService, DialogService>();
            builder.Services.AddSingleton<IThreadService, ThreadService>();
            builder.Services.AddSingleton<IPageService, PageService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<ILazyService, LazyService>();
            builder.Services.AddSingleton<IViewBaseService, ViewBaseService>();
            builder.Services.AddSingleton<IContacts>(provider => Communication.Contacts.Default);


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}