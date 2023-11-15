namespace Server_Application
{
    public partial class Application : Form
    {
        readonly string PLACEHOLDER;
        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Close(); //this demonstrates the login functionality, but still necessary to close this window on login

            if (username_input.Text == PLACEHOLDER && password_input.Text == PLACEHOLDER) //replace with database entries
            {
                //do the login thing

                //open main application window maybe (see below)

                //<formname> Form = new <formname>
                //<formname>.show();

                //<formname> refers to the name of the editor you want to use,
                //the same as the filename (case sensitive).
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}