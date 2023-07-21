namespace Uas;

public partial class SignUpPage : ContentPage
{
    public SignUpPage()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped_For_SignIn(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage.Navigation.PopModalAsync();
    }
}