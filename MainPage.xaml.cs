namespace club
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();
        }

      

        private async void login_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//home2");
        }
    }

}
