namespace NavigationPushBug;

public partial class MyPage : ContentPage
{
	public MyPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        Application.Current.MainPage.Navigation.PopModalAsync(false);
    }
	protected override void OnAppearing()
	{
		base.OnAppearing();
        this.BackgroundColor = Colors.Transparent;
    }
}