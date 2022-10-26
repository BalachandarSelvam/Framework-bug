using Microsoft.Maui.Layouts;

namespace LoadTImeChanges_Bug;

public partial class MainPage : ContentPage
{
    bool flag;
    public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        this.UpdateHeight();
    }

    private void ToolbarItem_Clicked(object sender, EventArgs e)
	{
        if (flag)
        {
            AbsoluteLayout.SetLayoutBounds(grid, new Rect(0, 0, 1, 0.5));
            AbsoluteLayout.SetLayoutFlags(grid, AbsoluteLayoutFlags.All);
            flag = !flag;
        }
        else
        {
            AbsoluteLayout.SetLayoutBounds(grid, new Rect(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(grid, AbsoluteLayoutFlags.All);
            flag |= !flag;
        }
    }
    private void UpdateHeight()
    {
        AbsoluteLayout.SetLayoutBounds(grid, new Rect(0, 0, 1, 0.5));
        AbsoluteLayout.SetLayoutFlags(grid, AbsoluteLayoutFlags.All);
    }
}

