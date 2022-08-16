namespace EduCube;

using EduCube.Models;
using EduCube.Services;
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

		//Views
		builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<FundsPage>();
        builder.Services.AddSingleton<StudentsPage>();
        builder.Services.AddSingleton<SubjectsPage>();
        builder.Services.AddSingleton<TeachersPage>();
        //Viewmodels



        //DB Repos
        string userDBPath = FileAccessHelper.GetLocalFilePath("educubeDatabase.db3");
        builder.Services.AddSingleton<AdminRepository>(s => ActivatorUtilities.CreateInstance<AdminRepository>(s, userDBPath));
        builder.Services.AddSingleton<FundRepository>(s => ActivatorUtilities.CreateInstance<FundRepository>(s, userDBPath));
        builder.Services.AddSingleton<StaffRepository>(s => ActivatorUtilities.CreateInstance<StaffRepository>(s, userDBPath));
        builder.Services.AddSingleton<StudentRepository>(s => ActivatorUtilities.CreateInstance<StudentRepository>(s, userDBPath));
        builder.Services.AddSingleton<SubjectRepository>(s => ActivatorUtilities.CreateInstance<SubjectRepository>(s, userDBPath));


        return builder.Build();
	}
}
