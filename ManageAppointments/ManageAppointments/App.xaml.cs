namespace ManageAppointments;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
