using Microsoft.Extensions.Logging;
using MauiSync.Core.Services;

namespace MauiSync.App;

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
			});


        // логирование, тк не получается отследить ошибку
        builder.Services.AddLogging(configure =>
        {
            configure.AddDebug();
            configure.AddConsole();
        });
        //
        // зарегистрировали после создания в сервисах файла AuthService.cs
        builder.Services.AddSingleton<IAuthService, AuthService>();



        builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
