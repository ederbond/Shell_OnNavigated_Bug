namespace Shell_OnNavigated_Bug;

public partial class PageA : ContentPage
{
	public PageA()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//PageB");
    }
}

