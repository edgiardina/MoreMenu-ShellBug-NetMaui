namespace MoreMenu_ShellBug;

public partial class SubPage5 : ContentPage
{
	int count = 0;

	public SubPage5()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("SubPage7");
	}
}

