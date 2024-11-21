using VenueApplication.DataAccess;

namespace VenueApplication
{
    public partial class Form1 : Form
    {
        string dbHost = Environment.GetEnvironmentVariable("DB_HOST")!;
        string dbUsername = Environment.GetEnvironmentVariable("DB_USERNAME")!;
        string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD")!;
        string dbName = Environment.GetEnvironmentVariable("DB_NAME")!;
        private DatabaseManager _databaseManager;

        public Form1()
        {
            InitializeComponent();

            _databaseManager = new DatabaseManager(dbHost, dbUsername, dbPassword, dbName);

            _databaseManager.ExecuteTestQuery();
          
        }
    }
}
