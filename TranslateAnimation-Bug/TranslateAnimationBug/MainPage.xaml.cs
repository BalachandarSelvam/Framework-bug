namespace TranslateAnimationBug;

public partial class MainPage : ContentPage
{
	private bool flag;
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (flag)
		{
			contentView.TranslateTo(0, 0, 1000);
			flag = !flag;
		}
		else
		{
            contentView.TranslateTo(0, 600, 1000);
            flag = !flag;
        }
	}
}

