namespace MoreMenu_ShellBug;

public partial class SubPage2 : ContentPage
{
	int count = 0;

	public SubPage2()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("SubPage7");
	}
}

