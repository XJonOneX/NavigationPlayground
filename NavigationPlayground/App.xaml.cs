namespace NavigationPlayground;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new NavigationPage(new MainPage());
		MainPage = new FlyoutPageDemo();
	}
}
