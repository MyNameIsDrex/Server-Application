using Server_Application.Properties;

namespace Server_Application
{
    public partial class Application : Form
    {
        readonly string PLACEHOLDER = "a";
        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            if (signin_checkbox.Checked)
            {
                databaseform Database = new databaseform();
                Database.Show();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Hide(); //this demonstrates the login functionality, but still necessary to close this window on login

            if (username_input.Text == PLACEHOLDER && password_input.Text == PLACEHOLDER) //replace with database entries
            {
                //do the login thing

                //open main application window (see below)

                databaseform Database = new databaseform();
                Database.Show();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void signin_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.stay_logged_in = signin_checkbox.Checked;
        }
    }
}