namespace Navigation;

[QueryProperty("MovieItem", "selectedMovie")]
public partial class FirstPage : ContentPage
{
    Movie movieItem;
    public Movie MovieItem
        {
        get=>movieItem; 
        set => movieItem = value;
        }

    public FirstPage()
	{
		InitializeComponent();
	}

    private  async void OnCounterClicked(object sender, EventArgs e)
    {

        var x = MovieItem.Title;
        var y = 1;
        var navigationParameter = new Dictionary<string, object>
    {
        { "selectedMovie", MovieItem }
    };
        await Shell.Current.GoToAsync("SecondPage", navigationParameter);
    }
}