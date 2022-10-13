namespace ToolbarText;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage())
		{
			BarTextColor = Colors.Orange
		};
	}
}
