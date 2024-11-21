using VenueApplication.DataAccess;
using Syncfusion.Windows.Forms;

namespace VenueApplication
{
    public partial class MainForm : MetroForm
    {
        string dbHost = Environment.GetEnvironmentVariable("DB_HOST")!;
        string dbUsername = Environment.GetEnvironmentVariable("DB_USERNAME")!;
        string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD")!;
        string dbName = Environment.GetEnvironmentVariable("DB_NAME")!;
        private DatabaseManager _databaseManager;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Venue Application";

            // Creates DatabaseManager object that will be used throughout lifetime of the application, should be passed to and method that will interact with the database
            _databaseManager = new DatabaseManager(dbHost, dbUsername, dbPassword, dbName);

            _databaseManager.ExecuteTestQuery();
          
        }
    }
}
