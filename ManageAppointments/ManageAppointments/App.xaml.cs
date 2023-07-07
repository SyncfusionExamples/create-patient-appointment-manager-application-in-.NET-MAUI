namespace ManageAppointments;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);
        window.Width = 800;
        window.Height = 800;
        return window;
    }
}
