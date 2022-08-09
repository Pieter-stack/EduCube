namespace EduCube;
using SkiaSharp.Views.Maui.Controls.Hosting;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
            .UseSkiaSharp(true)
            .UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Roboto-Bold.ttf", "Roboto-Bold");
                fonts.AddFont("Roboto-Regular.ttf", "Roboto-Regular");
                fonts.AddFont("Rubik-Bold.ttf", "Rubik-Bold");
                fonts.AddFont("Rubik-Regular.ttf", "Rubik-Regular");
            });

		return builder.Build();
	}
}
