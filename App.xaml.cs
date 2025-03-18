namespace club
{
    public partial class App : Application
    {
        public static DataTransactions.DBTrans DBTrans { get; set; }
        public App(DataTransactions.DBTrans dbtrans)
        {
            InitializeComponent();

            MainPage = new AppShell();
            DBTrans = dbtrans;
        }
    }
}
