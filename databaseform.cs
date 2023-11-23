using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Application
{
    public partial class databaseform : Form
    {
        //Some useful resources
        //https://docs.devexpress.com/WindowsForms/118397/common-features/data-source-wizard/wizard-pages/connect-to-a-database
        //https://www.sqlservercentral.com/articles/how-to-connect-sql-server-and-create-c-objects-for-data-management
        //https://www.guru99.com/c-sharp-access-database.html
        public databaseform()
        {
            InitializeComponent();
        }

        private void database_Load(object sender, EventArgs e)
        {

        }

        private void upload_button_Click(object sender, EventArgs e)
        {

        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            //uploadfile_dialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    /*
     * I have no idea how to actually do this
     * but here is a possibly functional template
     */
    public class data_query
    {
        string query;

        //returns an SQL command as a string
        string fetch(string select, string from)
        {
            query = "SELECT " + select + " FROM " + from;

            return query;
        }

        string fetch_where(string select, string from, string where)
        {
            query = "SELECT " + select + " FROM " + from + " WHERE " + where;

            return query;
        }

        string fetch_order(string select, string from, string orderby)
        {
            query = "SELECT " + select + " FROM " + from + " ORDER BY " + orderby + " DESC";

            return query;
        }


        //Quick example

        //Call either of these functions
        //fetch(select_textbox.Text, from_textbox.Text)
        //fetch_where(select_textbox.Text, from_textbox.Text, where_textbox.Text)
        //fetch_order(select_textbox.Text, from_textbox.Text, orderby_textbox.Text)

        //command = new SqlCommand(data_query.query, <SQL connection>);
        //dataReader = command.ExecuteReader(); Not sure if this one is necessary
    }
}
