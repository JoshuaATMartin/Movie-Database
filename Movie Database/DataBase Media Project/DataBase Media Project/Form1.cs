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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ViewAll viewpage = new ViewAll();
            viewpage.Show();
            Visible = false;
;        }

        private void button6_Click(object sender, EventArgs e)
        {
            insertMovies insertpage = new insertMovies();
            insertpage.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertSeries seriesPage = new insertSeries();
            seriesPage.Show();
            Visible = false;
        }

        private void viewSeriesbutton_Click(object sender, EventArgs e)
        {
            viewSeries viewSeriesPage = new viewSeries();
            viewSeriesPage.Show();
            Visible = false;
            

        }

        private void viewMoviesButton_Click(object sender, EventArgs e)
        {
            viewMovies viewMoviesPage = new viewMovies();
            viewMoviesPage.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Visible = false;
            searchSeries seriesSearchPage = new searchSeries();
            seriesSearchPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = false;
            searchMovies movieSearch = new searchMovies();
            movieSearch.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Visible = false;
            deleteMovie movieDel = new deleteMovie();
            movieDel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visible = false;
            deleteSeries seriesDel = new deleteSeries();
            seriesDel.Show();
        }
    }
}
