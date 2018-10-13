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
            // INIT
            string startUrl = @"https://www.discogs.com/search/?limit=250&sort=have%2Cdesc&genre_exact=Jazz&page=1";
            int numData = 1000;
            //bool singleGenre = 1;

            // CREATING SCRAPER
            DiscogsScraper Scraper = new DiscogsScraper()
            {
                startUrl = startUrl,
                numData = numData
            };

            Scraper.BeginScraping();

            Console.ReadLine();

        }
    }


}


