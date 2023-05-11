using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_Media_Project
{
    public partial class viewSeries : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Desktop\Database Project\New Project\DataBase Media Project\DataBase Media Project\Media.mdf;Integrated Security=True";

        public viewSeries()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter query = new SqlDataAdapter("select * from series", sqlCon);
                DataTable viewSeries = new DataTable();
                query.Fill(viewSeries);
                ViewSeriesGrid.DataSource = viewSeries;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 first = new Form1();
            first.Show();

        }
    }
}
