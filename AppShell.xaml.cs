namespace MoreMenu_ShellBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("SubPage7", typeof(SubPage7));
    }
}
