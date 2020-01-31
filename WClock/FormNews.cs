using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;


namespace WClock
{
    public partial class FormNews : Form
    {
        const string GOOGLE_NEWS = "https://newsapi.org/v2/top-headlines?sources=google-news&apiKey=18bae7a60fbe42a189e800a76ed28061";
        const string BBC_URL = "https://newsapi.org/v2/top-headlines?sources=bbc-news&apiKey=18bae7a60fbe42a189e800a76ed28061";

        List<string> URL_Collection;

        public News.Rootobject root { get; set; }

        public int NewsCounter { get; set; } = 0;
        public int SourceCounter { get; set; } = 0;
        public FormNews()
        {
            InitializeComponent();
            SetupList();
            CallAPI();
            // GetJSON();
        }

        private void SetupList()
        {
            this.URL_Collection = new List<string>();
            this.URL_Collection.Add(BBC_URL);
            this.URL_Collection.Add(GOOGLE_NEWS);
        }

        private async void CallAPI()
        {
            NewsCounter = 0;
            root = await Config.Deserialize(this.URL_Collection[SourceCounter]);
            SetupForm();
        }

        private void SetupForm()
        {
            //Cleanup
            DescriptionBox.Text = string.Empty;

            imageBox.Load(root.articles[NewsCounter].urlToImage);
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            titleLabel.Text = root.articles[NewsCounter].source.name;

            //DescriptionBox.AppendText($"News Article: {NewsCounter}{Environment.NewLine}{Environment.NewLine}");
            DescriptionBox.AppendText($"Posted At: {root.articles[NewsCounter].publishedAt}{Environment.NewLine}");
            DescriptionBox.AppendText(root.articles[NewsCounter].title + Environment.NewLine + Environment.NewLine);
            DescriptionBox.AppendText(root.articles[NewsCounter].description);


        }

        /* private async void GetJSON()
         {
             var json = await HTTP.GetAsync(BBC_URL);
             DescriptionBox.Text = json;
         }*/

        private void FormNews_Load(object sender, EventArgs e)
        {

        }


        private async void button1_Click(object sender, EventArgs e)
        {
            /* String news_ApiKey = "18bae7a60fbe42a189e800a76ed28061";
             var newsApiClient = new NewsApiClient(news_ApiKey);
             Console.WriteLine("getting News");

             try
             {
                 var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
                 {
                     Q = "Apple",
                     SortBy = SortBys.Popularity,
                     Language = Languages.EN,
                     From = new DateTime(2019, 11, 3)
                 });

                 if (articlesResponse.Status == Statuses.Ok)
                 {
                     Console.WriteLine(articlesResponse.TotalResults);
                     //here's the first 20
                     foreach (var article in articlesResponse.Articles)
                     {
                         //title
                         Console.WriteLine(article.Title);
                         //author
                         Console.WriteLine(article.Author);
                         //description
                         Console.WriteLine(article.Description);
                         //url
                         Console.WriteLine(article.Url);
                         //image
                         Console.WriteLine(article.UrlToImage);
                         //published at
                         Console.WriteLine(article.PublishedAt);
                     }
                     Console.WriteLine("got Everything");
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine("didn't get shit");
             }*/


        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (NewsCounter > 0)
            {
                this.NewsCounter--;
                SetupForm();
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (NewsCounter < 9)
            {
                this.NewsCounter++;
                SetupForm();
            }
        }

        private void buttonNextSource_Click(object sender, EventArgs e)
        {
            if (SourceCounter < URL_Collection.Count - 1)
            {
                this.SourceCounter++;
                CallAPI();
            }
        }

        private void buttonPrevSource_Click(object sender, EventArgs e)
        {
            if (SourceCounter > 0)
            {
                this.SourceCounter--;
                CallAPI();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            CallAPI();
            MessageBox.Show("All News Up To Date!");
        }
    }


}



