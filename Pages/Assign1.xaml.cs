

namespace club;

public partial class Assign1 : ContentPage
{
    private Models.ManagerClass selectedManager1;
    private Models.ClubClass selectedClub1;
    public Assign1()
	{

		InitializeComponent();
        ClubList1.ItemsSource = App.DBTrans.GetClubs();
        ManagerList.ItemsSource = App.DBTrans.GetManagers();
    }

    
    private void ClubList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedClub1 = (Models.ClubClass)e.Item;
        Models.Configuration.tappedClub = selectedClub1;

    }

    private void ManagerList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedManager1 = (Models.ManagerClass)e.Item;

        Models.Configuration.tappedManager = selectedManager1;

    }

    private async void next_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Assign2");
    }
}