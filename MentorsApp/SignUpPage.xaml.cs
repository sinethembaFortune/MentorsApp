namespace MentorsApp;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_For_signIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//LogIn");
    }
}