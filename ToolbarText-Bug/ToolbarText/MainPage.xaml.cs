namespace ToolbarText;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void toolbarItem_Clicked(object sender, EventArgs e)
	{
		if ((sender as ToolbarItem).Text == "Open")
		{
			toolbarItem.Text = "Close";
		}
		else
		{
			toolbarItem.Text = "Open";
		}
	}
}

