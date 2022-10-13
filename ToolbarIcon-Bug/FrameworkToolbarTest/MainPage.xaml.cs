using Microsoft.Maui.Controls;

namespace FrameworkToolbarTest;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		toolbarItem.IconImageSource = ImageSource.FromResource("FrameworkToolbarTest.NewFolder.baloons1.png");
	}

    void toolbarItem_Clicked(System.Object sender, System.EventArgs e)
    {
		
		if ((sender as ToolbarItem).Text == "Open")
		{
			toolbarItem.Text = "Close";
            toolbarItem.IconImageSource = ImageSource.FromResource("FrameworkToolbarTest.NewFolder.spider1.png");
        }
        else
		{
			toolbarItem.Text = "Open";
            toolbarItem.IconImageSource = ImageSource.FromResource("FrameworkToolbarTest.NewFolder.baloons1.png");
        }
    }

}


