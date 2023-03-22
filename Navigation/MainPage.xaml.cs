namespace Navigation;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		Movie movie = new()
		{
			ID = 1,
			Title = "Titanic",
			Genre = "Drama",
			ReleaseDate = new DateTime(),
			Price = 200,
		

		};
        var navigationParameter = new Dictionary<string, object>
    {
        { "selectedMovie", movie }
    };
        await Shell.Current.GoToAsync($"FirstPage",navigationParameter);
    }
}

