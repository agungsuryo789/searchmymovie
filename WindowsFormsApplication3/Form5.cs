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
    public partial class Form5 : Form
    {
        WebClient a = null;
        public Form5()
        {
            a = new WebClient();
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            var data =
            a.DownloadString("https://api.themoviedb.org/3/discover/movie?api_key=4e580ce2ce142ef172500fe4a8ec6b7d&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1");
            JObject obj = JObject.Parse(data);
            String result = "";
            string result2 = "";
            string result3 = "";
            string result4 = "";
            string result5 = "";



            result += "Movie Title: " + obj["results"][0]["original_title"];
            result += "\nMovie Id: " + obj["results"][0]["id"];
            result += "\nRelease Date: " + obj["results"][0]["release_date"];
            result += "\nPopularity: " + obj["results"][0]["popularity"];
            result += "\nSummary: " + obj["results"][0]["overview"];
            pbt1.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][0]["poster_path"];

            result2 += "Movie Title: " + obj["results"][1]["original_title"];
            result2 += "\nMovie Id: " + obj["results"][1]["id"];
            result2 += "\nRelease Date: " + obj["results"][1]["release_date"];
            result2 += "\nPopularity: " + obj["results"][1]["popularity"];
            result2 += "\nSummary: " + obj["results"][1]["overview"];
            pbt2.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][1]["poster_path"];

            result3 += "Movie Title: " + obj["results"][2]["original_title"];
            result3 += "\nMovie Id: " + obj["results"][2]["id"];
            result3 += "\nRelease Date: " + obj["results"][2]["release_date"];
            result3 += "\nPopularity: " + obj["results"][2]["popularity"];
            result3 += "\nSummary: " + obj["results"][2]["overview"];
            pbt3.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][2]["poster_path"];

            result4 += "Movie Title: " + obj["results"][3]["original_title"];
            result4 += "\nMovie Id: " + obj["results"][3]["id"];
            result4 += "\nRelease Date: " + obj["results"][3]["release_date"];
            result4 += "\nPopularity: " + obj["results"][3]["popularity"];
            result4 += "\nSummary: " + obj["results"][3]["overview"];
            pbt4.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][3]["poster_path"];

            result5 += "Movie Title: " + obj["results"][4]["original_title"];
            result5 += "\nMovie Id: " + obj["results"][4]["id"];
            result5 += "\nRelease Date: " + obj["results"][4]["release_date"];
            result5 += "\nPopularity: " + obj["results"][4]["popularity"];
            result5 += "\nSummary: " + obj["results"][4]["overview"];
            pbt5.ImageLocation = "http://image.tmdb.org/t/p/w185/" + obj["results"][4]["poster_path"];

            lbt1.Text = result;
            lbt2.Text = result2;
            lbt3.Text = result3;
            lbt4.Text = result4;
            lbt5.Text = result5;
        }

        private void lbt3_Click(object sender, EventArgs e)
        {

        }
    }
}
