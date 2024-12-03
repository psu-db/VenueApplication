using VenueApplication.DataAccess;
using Syncfusion.Windows.Forms;
using VenueApplication.Models;

namespace VenueApplication
{
    public partial class MainForm : MetroForm
    {
        public DatabaseManager databaseManager;
        public app_user user;
        public user_wallet user_wallet;

        public MainForm(app_user user, user_wallet user_wallet, DatabaseManager databaseManager)
        {
            InitializeComponent();
            this.Text = "Venue Application";
            this.databaseManager = databaseManager;
            this.user = user;
            this.user_wallet = user_wallet;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (user.user_type == "ADMIN")
            {
                adminControlsButton.Visible = true;
                adminControlsButton.Enabled = true;
            }
        }

        private void switchToCreateNewEventTabButton_Click(object sender, EventArgs e)
        {
            tabControlAdv2.SelectedTab = createNewEventTab;
        }

        private void eventManagerButton_Click(object sender, EventArgs e)
        {
            tabControlAdv2.SelectedTab = eventManagerTab;
        }
    }
}
