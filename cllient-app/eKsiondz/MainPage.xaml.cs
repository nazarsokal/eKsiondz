namespace eKsiondz;

public partial class MainPage : ContentPage
{
	private readonly ApiService _apiService;

	public MainPage()
	{
		InitializeComponent();
		_apiService = new ApiService();
	}

	private async void GetRequestButton_Clicked(object sender, System.EventArgs e)
	{
		string message = await _apiService.GetServerMessageAsync($"person/{Entry.Text}");
		await DisplayAlert("Server Message", message, "OK");
	}
	
}

