namespace Navigation;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(FirstPage), typeof(FirstPage));
        Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
        Routing.RegisterRoute(nameof(ThirdPage), typeof(ThirdPage));
        Routing.RegisterRoute(nameof(Login), typeof(Login));
        Routing.RegisterRoute(nameof(Settings), typeof(Settings));

    }
}
