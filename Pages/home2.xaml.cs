namespace club;

public partial class home2 : ContentPage
{
	public home2()
	{
		InitializeComponent();
	}

    private async void next_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CreateClub");
    }
}