namespace Uas;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

    private  void TapGestureRecognizer_Tapped_For_SignUp(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new SignUpPage());
    }
}