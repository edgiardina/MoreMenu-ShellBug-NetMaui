﻿namespace MoreMenu_ShellBug;

public partial class SubPage : ContentPage
{
	int count = 0;

	public SubPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("SubPage7");
	}
}

