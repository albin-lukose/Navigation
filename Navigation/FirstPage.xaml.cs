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
        await Shell.Current.GoToAsync("SecondPage");
    }
}