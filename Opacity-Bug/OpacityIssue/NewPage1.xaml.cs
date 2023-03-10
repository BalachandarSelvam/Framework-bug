namespace OpacityIssue;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
          frame.Opacity = frame.Opacity == 1 ? 0 : 1;
    }
}