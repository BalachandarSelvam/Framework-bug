﻿namespace TouchEffects;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage())
		{
			BarBackgroundColor = Color.FromArgb("2194f3")
		};
	}
}
