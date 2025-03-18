using System.Net;

namespace club;

public partial class CreateClub : ContentPage
{
    private Models.ClubClass selectedClub;
	public CreateClub()
	{
		InitializeComponent();
	}

    private void add_Clicked(object sender, EventArgs e)
    {
        string language = "";
        if(english.IsChecked)
        {
            language = "EN";
        }
        if (turkish.IsChecked)
        {
            language = "TUR";
        }
        if (spanish.IsChecked)
        {
            language = "SP";
        }

        var selectedCategory = new List<string>();
        if (fun.IsChecked)
        {
            selectedCategory.Add("Fun");
        }
        if (science.IsChecked)
        {
            selectedCategory.Add("Science");
        }
        if (academy.IsChecked)
        {
            selectedCategory.Add("Academy");
        }
        if (leisure.IsChecked)
        {
            selectedCategory.Add("Leisure");
        }
       

        var selectedCategoryString = string.Join(", ", selectedCategory);


        App.DBTrans.Add(new Models.ClubClass
        {

            club_Name  = name.Text,
            club_Contact = contact.Text,
            club_language = language,
            club_Category = selectedCategoryString,
            

        });
        ClubList.ItemsSource = App.DBTrans.GetClubs();
    }

    private void show_Clicked(object sender, EventArgs e)
    {
        ClubList.ItemsSource = App.DBTrans.GetClubs();
    }

    private void delete_Clicked(object sender, EventArgs e)
    {
        if (selectedClub != null)
        {
            App.DBTrans.Delete(selectedClub.club_ID);
            ClubList.ItemsSource = App.DBTrans.GetClubs();
            selectedClub = null;
            delete.IsEnabled = false;
        }
    }

    private void ClubList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedClub = (Models.ClubClass)e.Item;
        delete.IsEnabled = selectedClub != null;
    }
}