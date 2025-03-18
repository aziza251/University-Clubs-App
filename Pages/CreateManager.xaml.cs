namespace club;

public partial class CreateManager : ContentPage
{
    private Models.ManagerClass selectedManager;
	public CreateManager()
	{
		InitializeComponent();
	}

    private void ManagerList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedManager = (Models.ManagerClass)e.Item;
        delete.IsEnabled = selectedManager != null;
    }

    private void add_Clicked(object sender, EventArgs e)
    {
        string year = "";
        if (first.IsChecked)
        {
            year = "First Year";
        }
        if (second.IsChecked)
        {
            year = "Second Year";
        }
        if (third.IsChecked)
        {
            year = "Third Year";
        }
        if (fourth.IsChecked)
        {
            year = "Fourth Year";
        }
        App.DBTrans.Add(new Models.ManagerClass
        {

            manager_Name = manager_name.Text,
            manager_Identity = manager_id.Text,
            manager_Department = dept.Text,
            manager_Year = year


        });
        ManagerList.ItemsSource = App.DBTrans.GetManagers();
        manager_name.Text = string.Empty;
        manager_id.Text = string.Empty;
        dept.Text = string.Empty;

    }

    private void show_Clicked(object sender, EventArgs e)
    {
        ManagerList.ItemsSource = App.DBTrans.GetManagers();
    }

    private void delete_Clicked(object sender, EventArgs e)
    {
        if (selectedManager != null)
        {
            App.DBTrans.Deletee(selectedManager.manager_ID);
            ManagerList.ItemsSource = App.DBTrans.GetClubs();
            selectedManager = null;
            delete.IsEnabled = false;
        }

    }
}