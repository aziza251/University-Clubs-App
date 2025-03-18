namespace club;

public partial class OfflineEvent : ContentPage
{
    private Models.OfflineClass selectedOffline;
	public OfflineEvent()
	{
		InitializeComponent();
	}

    private void OfflineList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedOffline = (Models.OfflineClass)e.Item;
        delete_event.IsEnabled = selectedOffline != null;
    }

    private void add_event_Clicked(object sender, EventArgs e)
    {
        string category = "";
        if (fun.IsChecked)
        {
            category = "Fun";
        }
        if (sport.IsChecked)
        {
            category = "Sport";
        }
        if (tech.IsChecked)
        {
            category = "Tech";
        }
        if (language.IsChecked)
        {
            category = "Language";
        }
        if (culture.IsChecked)
        {
            category = "Culture";
        }
        if (game.IsChecked)
        {
            category = "Game";
        }

        App.DBTrans.Add(new Models.OfflineClass
        {
            offline_event_name = event_name.Text,
            offline_event_date = event_date.Text,
            offline_event_time = event_time.Text,
            offline_event_place = event_place.Text,
            offline_event_category = category,



        });

        OfflineList.ItemsSource = App.DBTrans.GetOfflineEvents();
             event_name.Text = string.Empty;
             event_date.Text = string.Empty;
             event_time.Text = string.Empty;
             event_place.Text = string.Empty;
             

    }

    private void show_event_Clicked(object sender, EventArgs e)
    {

        OfflineList.ItemsSource = App.DBTrans.GetOfflineEvents();
    }

    private void delete_event_Clicked(object sender, EventArgs e)
    {
        if (selectedOffline != null)
        {
            App.DBTrans.Deleteeeee(selectedOffline.offline_event_ID);
            OfflineList.ItemsSource = App.DBTrans.GetOfflineEvents();
            selectedOffline = null;
            delete_event.IsEnabled = false;
        }
    }

    private async void back_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CreateEvent");
    }
}