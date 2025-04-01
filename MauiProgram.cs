using CommunityToolkit.Maui;
using MauiTabbedApp.Services.Navigation;
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
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Register the ViewModel with DI containers
            builder.Services.AddTransient<AddModalView, AddModalViewModel>();
            builder.Services.AddTransient<ContactPermissionsView, ContactPermissionsViewModel>();
            builder.Services.AddTransient<HomeView, HomeViewModel>();
            builder.Services.AddTransient<ReproHistoryView, ReproHistoryViewModel>();
            builder.Services.AddTransient<MainPageView, MainPageViewModel>();
            builder.Services.AddTransient<CollectionViewOrientationView, CollectionViewOrientationViewModel>();
            builder.Services.AddTransient<ViewModelBase>();

            // Register the services with DI containers
            builder.Services.AddSingleton<IContacts>(provider => Communication.Contacts.Default);
            builder.Services.AddSingleton<INavigationService, NavigationService>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}