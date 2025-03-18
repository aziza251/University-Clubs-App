
namespace club;
public partial class Assign2 : ContentPage
{
    private Models.AssignClass selectedAssign;
   
	public Assign2()
	{
		InitializeComponent();
	}

    private void assign_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.Add(new Models.AssignClass
        {
            assign_club = Models.Configuration.tappedClub.club_Name,
            assign_manager = Models.Configuration.tappedManager.manager_Name

        });

        AssignList.ItemsSource = App.DBTrans.GetAssignList();

    }

    private void delete_Clicked(object sender, EventArgs e)
    {
        if (selectedAssign != null)
        {
            App.DBTrans.Deleteeeeee(selectedAssign.assign_ID);
            AssignList.ItemsSource = App.DBTrans.GetAssignList();
            selectedAssign = null;
            delete.IsEnabled = false;
        }
    }

    private async void home_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//home2");
    }

    private void AssignList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedAssign = (Models.AssignClass)e.Item;
        delete.IsEnabled = true;

    }
}