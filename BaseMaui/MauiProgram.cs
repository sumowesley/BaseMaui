﻿using CommunityToolkit.Maui;
using CustomShellMaui;
using Microsoft.Extensions.Logging;
using The49.Maui.Insets;

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
                .UseCustomShellMaui()
                .UseInsets()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddTransient<ScreenOnePage>();
            builder.Services.AddTransient<ScreenOnePageViewModel>();
            builder.Services.AddTransient<ScreenTwoPage>();
            builder.Services.AddTransient<ScreenTwoPageViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
