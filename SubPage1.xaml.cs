namespace MoreMenu_ShellBug;

public partial class SubPage1 : ContentPage
{
	int count = 0;

	public SubPage1()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("SubPage7");
	}
}

