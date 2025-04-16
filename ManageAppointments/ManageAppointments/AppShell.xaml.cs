namespace ManageAppointments;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private  void MenuItem_Clicked(object? sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage();
        App.Current.MainPage.Navigation.PushAsync(new LoginPage());
    }
}
