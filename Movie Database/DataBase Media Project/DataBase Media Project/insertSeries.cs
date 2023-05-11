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
    public partial class insertSeries : Form
    {
        string name;
        string year;
        float rating;
        long votes;
        string age;
        string genre1;
        string genre2;
        string genre3;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Desktop\Database Project\New Project\DataBase Media Project\DataBase Media Project\Media.mdf;Integrated Security=True";

        public insertSeries()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                nameTxt.Focus();
                errorProvider1.SetError(nameTxt, "Cannot be null");
            }
            else if (string.IsNullOrWhiteSpace(yearTxt.Text))
            {
                yearTxt.Focus();
                errorProvider2.SetError(yearTxt, "Cannot be null");
            }
            else if (string.IsNullOrWhiteSpace(RateTxt.Text))
            {
                RateTxt.Focus();
                errorProvider3.SetError(RateTxt, "Cannot be null");
            }
            else if (string.IsNullOrWhiteSpace(VotesTxt.Text))
            {
                VotesTxt.Focus();
                errorProvider5.SetError(VotesTxt, "Cannot be null");
            }
            else if (string.IsNullOrWhiteSpace(AgeTxt.Text))
            {
                AgeTxt.Focus();
                errorProvider4.SetError(AgeTxt, "Cannot be null");
            }
            else if (string.IsNullOrWhiteSpace(genre1Txt.Text))
            {
                genre1Txt.Focus();
                errorProvider6.SetError(genre1Txt, "Cannot be null");
            }
            else
            {
                name = nameTxt.Text;
                year = yearTxt.Text;
                rating = Convert.ToSingle(RateTxt.Text);
                age = AgeTxt.Text;
                votes = Convert.ToInt64(VotesTxt.Text);
                genre1 = genre1Txt.Text;
                genre2 = genre2Txt.Text;
                genre3 = genre3Txt.Text;

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand query = new SqlCommand("insert into series(Name,Year,IMDB,Votes,Age_Restriction,Genre_1,Genre_2,Genre_3) VALUES ('" + name + "','" + year + "'," + rating + "," + votes + ",'" + age + "','" + genre1 + "','" + genre2 + "','" + genre3 + "')", sqlCon);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Series successfully added", null, MessageBoxButtons.OK);

                }
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
