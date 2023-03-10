using System.Collections.ObjectModel;

namespace OpacityIssue;

public partial class NewPage2 : ContentPage
{
    public ObservableCollection<int> Numbers { get; set; }
    public NewPage2()
	{
        Numbers = new ObservableCollection<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        InitializeComponent();
        BindingContext = this;
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
         listview.Opacity = listview.Opacity == 1 ? 0 : 1;
    }
}