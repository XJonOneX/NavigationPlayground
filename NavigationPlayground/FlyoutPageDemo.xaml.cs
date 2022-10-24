namespace NavigationPlayground;

public partial class FlyoutPageDemo : FlyoutPage
{
	public FlyoutPageDemo()
	{
		InitializeComponent();
		flyoutMenuPage.collectionView.SelectionChanged += OnSelectionChanged;
	}

	void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
		if (item != null)
		{
			//flyoutMenuPage.IsPresented = false;
			//Navigation.PushAsync(new Page2());

			//Detail = new NavigationPage(new Page2());

			//Application.Current.MainPage.Navigation.PushAsync(new Page2());
			//Navigation.PushAsync(new NavigationPage((Page)Activator.CreateInstance(item.TargetType)));

			//This line works, but doesn't display the back arrow
			//I'm asuuming because it wasn't done with Navigation.PushAsync
			Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
		}
	}
}