using System;

namespace club;

public partial class CreateEvent : ContentPage
{
    private Models.OnlineClass selectedEvent1;

    private Models.OfflineClass selectedEvent2;
    public CreateEvent()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        OfflineList.ItemsSource = App.DBTrans.GetOfflineEvents();
        OnlineList.ItemsSource = App.DBTrans.GetOnlineEvents();
    }
    private async void create_Clicked(object sender, EventArgs e)
    {
        string type = "";
        if (online.IsChecked)
        {
            await Shell.Current.GoToAsync("//OnlineEvent");
            type = "Fun";
        }
        if (offline.IsChecked)
        {
            await Shell.Current.GoToAsync("//OfflineEvent");
            type = "Sport";
        }

    }

   
    private void delete_Clicked(object sender, EventArgs e)
    {
        if (selectedEvent1 != null)
        {
            App.DBTrans.Deleteeee(selectedEvent1.online_event_ID);
            OnlineList.ItemsSource = App.DBTrans.GetOnlineEvents();
            selectedEvent1 = null;
            delete.IsEnabled = false;
        }
       else  if (selectedEvent2 != null)
        {
            App.DBTrans.Deleteeeee(selectedEvent2.offline_event_ID);
            OfflineList.ItemsSource = App.DBTrans.GetOfflineEvents();
            selectedEvent2 = null;
            delete.IsEnabled = false;
        }
    }

   

    private void OnlineList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedEvent1 = (Models.OnlineClass)e.Item;

        delete.IsEnabled = selectedEvent1 != null;
    }

    private void OfflineList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedEvent2 = (Models.OfflineClass)e.Item;

        delete.IsEnabled = selectedEvent2 != null;
    }
}