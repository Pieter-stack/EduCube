namespace EduCube;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	async void OnLoginClicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		await DisplayAlert("Alert", "Login Button Clicked!", "OK");
	}
    //TODO:
    //1. Email Validation with EmailValidationBehavior ('https://docs.microsoft.com/en-us/dotnet/communitytoolkit/maui/behaviors/email-validation-behavior')
    //2.Login/Authentication funcationality with Username and Password.
}

