using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using HtmlAgilityPack;

namespace Discogs_Scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "https://www.discogs.com";


        }
    }

    public class DiscogsScraper
    {
        private string startingPage; //Start page to begin scraping
        private int numberOfReleases;

        private HtmlDocument GetStartingPage(string url)
        {

            //return htmlDoc;
        }
        private string GetCoverImgUrl(HtmlNode htmlNode)
        {
            return imgUrl;
        }
        private string GetGenre(HtmlNode htmlNode)
        {
            return genre;
        }
        private string GetTitle(HtmlNode htmlNode)
        {
            return title;
        }
        private string GetReleaseYear(HtmlNode htmlNode)
        {
            return releaseYear;
        }


    }

    public class DataBaseHandler
    {

           

    }
    
    // Functions:
    //      GetStartingPage(string url);
    //      ScrapePages(int numberOfReleases, bool pureGenres);
    //
    //      GetGenre(HtmlDocument hmtlDoc);
    //      GetTitle(HtmlDocument hmtlDoc);
    //      GetReleaseYear(HtmlDocument hmtlDoc);
    //      



}
