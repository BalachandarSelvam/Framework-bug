namespace NavigationPushBug;

public partial class MainPage : ContentPage
{
    MyPage myPage;
    public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        myPage = new MyPage();
        Application.Current.MainPage.Navigation.PushModalAsync(myPage, false);
    }
}

