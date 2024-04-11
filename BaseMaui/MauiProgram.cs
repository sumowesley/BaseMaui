﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using The49.Maui.Insets;
using Nalu;

namespace BaseMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseNaluNavigation<App>(nav => nav.AddPages((pageType) => pageType.Name.Replace("Page", "ViewModel")))
                .UseInsets()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();


        }
    }
}
