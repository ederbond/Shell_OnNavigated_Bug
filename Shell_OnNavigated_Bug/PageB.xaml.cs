namespace Shell_OnNavigated_Bug;

public partial class PageB : ContentPage
{
	public PageB()
	{
		InitializeComponent();
	}

    private async void GoToC(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("PageC");
    }

    private async void GoToD(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//PageD");
    }
}

