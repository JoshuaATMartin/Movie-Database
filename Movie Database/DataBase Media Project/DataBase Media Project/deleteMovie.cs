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
    public partial class deleteMovie : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Desktop\Database Project\New Project\DataBase Media Project\DataBase Media Project\Media.mdf;Integrated Security=True";
        public deleteMovie()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                nameTxt.Focus();
                errorProvider1.SetError(nameTxt, "Cannot be null");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where name = '" + nameTxt.Text + "'", sqlCon);
                    DataTable ratingResult1 = new DataTable();
                    query1.Fill(ratingResult1);
                    searchMoviesGrid.DataSource = ratingResult1;
                }
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                nameTxt.Focus();
                errorProvider1.SetError(nameTxt, "Cannot be null");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand query1 = new SqlCommand("delete from movies where name = '" + nameTxt.Text + "'", sqlCon);
                    query1.ExecuteNonQuery();
                    MessageBox.Show("Movie successfully deleted", null, MessageBoxButtons.OK);
                    sqlCon.Close();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 page = new Form1();
            page.Show();
        }
    }
}
