using Microsoft.Maui.Controls.Shapes;

namespace ContentClipBug;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var heightPercentage = (this.Height - 100) / this.Height;
        AbsoluteLayout.SetLayoutBounds(this.contentView, new Rect(0, 0, 1, heightPercentage));

        this.contentView.Content.Clip = new RoundRectangleGeometry(new CornerRadius(20,20,0,0), new Rect(0, 0, this.Width, this.Height - 100));
    }
}

