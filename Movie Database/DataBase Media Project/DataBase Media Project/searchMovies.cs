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
    public partial class searchMovies : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Desktop\Database Project\New Project\DataBase Media Project\DataBase Media Project\Media.mdf;Integrated Security=True";
        public searchMovies()
        {
            InitializeComponent();
            ratingdrop.SelectedIndex = 1;
            ageCombo.SelectedIndex = 0;
            genreBox.SelectedIndex = 0;
        }

        private void ratingdrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                int rating = ratingdrop.SelectedIndex;
                switch (rating)
                {
                    case 0:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 1", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 1:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 2", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 2:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 3", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 3:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 4", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 4:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 5", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 5:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 6", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 6:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 7", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 7:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 8", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 8:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 9", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    default:
                        {
                            break;
                        }


                }
                sqlCon.Close();

            }
        }

        private void ageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                int age = ageCombo.SelectedIndex;
                switch (age)
                {
                    case 0:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where Age_Restriction = 'PG-13'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 1:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where Age_Restriction = 'TV-MA'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 2:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where Age_Restriction = 'R'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 3:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where Age_Restriction = 'G'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                sqlCon.Close();
            }
        }

        private void genreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                int genre = genreBox.SelectedIndex;
                switch (genre)
                {
                    case 0:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Drama' or genre_2 = 'Drama' or genre_3 = 'Drama'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 1:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Action' or genre_2 = 'Action' or genre_3 = 'Action'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 2:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Adventure' or genre_2 = 'Adventure' or genre_3 = 'Adventure'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 3:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Biography' or genre_2 = 'Biography' or genre_3 = 'Biography'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 4:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Romance' or genre_2 = 'Romance' or genre_3 = 'Romance'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 5:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'War' or genre_2 = 'War' or genre_3 = 'War'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 6:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Comedy' or genre_2 = 'Comedy' or genre_3 = 'Comedy'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 7:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Fantasy' or genre_2 = 'Fantasy' or genre_3 = 'Fantasy'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 8:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Thriller' or genre_2 = 'Thriller' or genre_3 = 'Thriller'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 9:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Crime' or genre_2 = 'Crime' or genre_3 = 'Crime'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 10:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Mystery' or genre_2 = 'Mystery' or genre_3 = 'Mystery'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 11:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Sci-Fi' or genre_2 = 'Sci-Fi' or genre_3 = 'Sci-Fi'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 12:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'History' or genre_2 = 'History' or genre_3 = 'History'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 13:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Western' or genre_2 = 'Western' or genre_3 = 'Western'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    case 14:
                        {
                            SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where genre_1 = 'Animation' or genre_2 = 'Animation' or genre_3 = 'Animation'", sqlCon);
                            DataTable ratingResult1 = new DataTable();
                            query1.Fill(ratingResult1);
                            searchMoviesGrid.DataSource = ratingResult1;
                            break;
                        }
                    default:
                        {
                            break;
                        }


                }
                sqlCon.Close();
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                if ((string.IsNullOrWhiteSpace(nameTxt.Text)) && (string.IsNullOrWhiteSpace(yearTxt.Text)))
                {
                    int rating = ratingdrop.SelectedIndex;
                    switch (rating)
                    {
                        case 0:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 1 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 1:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 2 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 2:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 3 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 3:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 4 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 4:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 5 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 5:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 6 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 6:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 7 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 7:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 8 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 8:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where IMDB >= 9 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }


                }
                else if (string.IsNullOrWhiteSpace(nameTxt.Text))
                {
                    int rating = ratingdrop.SelectedIndex;
                    switch (rating)
                    {
                        case 0:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 1 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 1:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 2 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 2:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 3 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 3:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 4 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 4:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 5 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 5:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 6 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 6:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 7 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 7:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 8 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        case 8:
                            {
                                SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where year = '" + yearTxt.Text + "' and IMDB >= 9 and Age_Restriction = '" + ageCombo.SelectedItem + "' and  genre_1 ='" + genreBox.SelectedItem + "'  or genre_2 = '" + genreBox.SelectedItem + "' or genre_3 = '" + genreBox.SelectedItem + "'", sqlCon);
                                DataTable ratingResult1 = new DataTable();
                                query1.Fill(ratingResult1);
                                searchMoviesGrid.DataSource = ratingResult1;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }

                else
                {
                    SqlDataAdapter query1 = new SqlDataAdapter("select * from movies where name = '" + nameTxt.Text + "'", sqlCon);
                    DataTable ratingResult1 = new DataTable();
                    query1.Fill(ratingResult1);
                    searchMoviesGrid.DataSource = ratingResult1;
                }
                sqlCon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 firstpage = new Form1();
            firstpage.Show();
        }
    }
}
