namespace MentorsApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_For_signUp(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }
}