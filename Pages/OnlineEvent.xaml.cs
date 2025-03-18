namespace club;

public partial class OnlineEvent : ContentPage
{
    private Models.OnlineClass selectedOnline;
	public OnlineEvent()
	{
		InitializeComponent();
	}

    private void OvlineList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedOnline = (Models.OnlineClass)e.Item;
        delete_event.IsEnabled = selectedOnline != null;
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

        string platform = "";
        if (zoom.IsChecked)
        {
            platform = "Zoom";
        }
        if (google.IsChecked)
        {
            platform = "Google Meets";
        }
        App.DBTrans.Add(new Models.OnlineClass
        {
            online_event_name = event_name.Text,
            online_event_date = event_date.Text,
            online_event_time = event_time.Text,
            online_event_platform = platform,
            online_event_category = category,



        });

        OnlineList.ItemsSource = App.DBTrans.GetOnlineEvents();
        event_name.Text = string.Empty;
        event_date.Text = string.Empty;
        event_time.Text = string.Empty;
    

    }

    private void show_event_Clicked(object sender, EventArgs e)
    {
        OnlineList.ItemsSource = App.DBTrans.GetOnlineEvents();
    }

    private void delete_event_Clicked(object sender, EventArgs e)
    {
        if (selectedOnline != null)
        {
            App.DBTrans.Deleteeee(selectedOnline.online_event_ID);
            OnlineList.ItemsSource = App.DBTrans.GetOnlineEvents();
            selectedOnline = null;
            delete_event.IsEnabled = false;
        }
    }

    private async void back_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CreateEvent");
    }
}