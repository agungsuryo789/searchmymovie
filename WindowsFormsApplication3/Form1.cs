using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        WebClient a = null;
        
        
        public Form1()
        {
            
            a = new WebClient();
            
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void bbyt_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            

            string yturl = tbfilm.Text;
            form2.webBrowser1.Navigate($"https://www.youtube.com/results?search_query={yturl} trailer");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String film = tbfilm.Text;
                var data =
                a.DownloadString("https://api.themoviedb.org/3/search/movie?api_key=4e580ce2ce142ef172500fe4a8ec6b7d&language=en-US&query= " + film + "&page=1&include_adult=false");
                JObject obj = JObject.Parse(data);
                String result = "";
                string result2 = "";
                string result3 = "";
                string result4 = "";
                string result5 = "";



                result += "Movie Title: " + obj["results"][0]["original_title"];
                result += "\nMovie Id: " + obj["results"][0]["id"];
                result += "\nRelease Date: " + obj["results"][0]["release_date"];
                result += "\nRating: " + obj["results"][0]["vote_average"];
                result += "\nSummary: " + obj["results"][0]["overview"];
                pictureBox1.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][0]["poster_path"];

                result2 += "Movie Title: " + obj["results"][1]["original_title"];
                result2 += "\nMovie Id: " + obj["results"][1]["id"];
                result2 += "\nRelease Date: " + obj["results"][1]["release_date"];
                result2 += "\nRating: " + obj["results"][1]["vote_average"];
                result2 += "\nSummary: " + obj["results"][1]["overview"];
                pictureBox2.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][1]["poster_path"];

                result3 += "Movie Title: " + obj["results"][2]["original_title"];
                result3 += "\nMovie Id: " + obj["results"][2]["id"];
                result3 += "\nRelease Date: " + obj["results"][2]["release_date"];
                result3 += "\nRating: " + obj["results"][2]["vote_average"];
                result3 += "\nSummary: " + obj["results"][2]["overview"];
                pictureBox3.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][2]["poster_path"];

                result4 += "Movie Title: " + obj["results"][3]["original_title"];
                result4 += "\nMovie Id: " + obj["results"][3]["id"];
                result4 += "\nRelease Date: " + obj["results"][3]["release_date"];
                result4 += "\nRating: " + obj["results"][3]["vote_average"];
                result4 += "\nSummary: " + obj["results"][3]["overview"];
                pictureBox7.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][3]["poster_path"];

                result5 += "Movie Title: " + obj["results"][4]["original_title"];
                result5 += "\nMovie Id: " + obj["results"][4]["id"];
                result5 += "\nRelease Date: " + obj["results"][4]["release_date"];
                result5 += "\nRating: " + obj["results"][4]["vote_average"];
                result5 += "\nSummary: " + obj["results"][4]["overview"];
                pictureBox8.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][4]["poster_path"];

                lbt1.Text = result;
                lbt2.Text = result2;
                lbt3.Text = result3;
                label4.Text = result4;
                label5.Text = result5;


                pl1.Visible = true;
                pl2.Visible = true;
                pl3.Visible = true;
                pl4.Visible = true;
                panel3.Visible = true;

                label6.Visible = true;
                bgoogle.Visible = true;

                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;

                

            }
            catch (Exception)
            {
                MessageBox.Show("The data you are looking for are not in the database or your inquiry is wrong");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel4.Visible = !panel4.Visible;
            panel1.Visible = !panel1.Visible;

            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel4.Visible = !panel4.Visible;

            
        }

        private void bgoogle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
            

            string google = tbfilm.Text;
            form3.webBrowser1.Navigate($"https://www.google.co.id/search?biw=1600&bih=720&ei=FhHzWYP8C8fQvgTqiIBo&q={google}&oq={google}&gs_l=psy-ab.3..35i39k1l2j0i67k1l5j0i46i67k1j46i67k1l2j0i67k1j0i20i263k1.2700.3433.0.3682.6.6.0.0.0.0.167.167.0j1.1.0....0...1.1.64.psy-ab..5.1.166....0.aPqtv1nnQf8 film");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            form6.Show();
            this.Hide();
        }
    }
    }

