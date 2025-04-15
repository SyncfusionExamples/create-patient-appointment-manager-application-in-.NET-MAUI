namespace ManageAppointments;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        var loginPage = new LoginPage();
        var navPage = new NavigationPage(loginPage);

        var currentApp = App.Current;

        if (currentApp?.Windows?.Count > 0 && currentApp.Windows[0] != null)
        {
            currentApp.Windows[0].Page = navPage;
        }
    }

}
