using System;
using System.IO;
using HtmlAgilityPack;


namespace Discogs_Scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            // INIT
            string startUrl = @"https://www.discogs.com/search/?limit=250&sort=have%2Cdesc&genre_exact=Jazz&page=1";
            string genre = "Jazz";
            int numData = 1000;

            // FUNK - MOST COLLECTED - LPs/VINYL/ALBUM https://www.discogs.com/search/?sort=have%2Cdesc&format_exact=LP&format_exact=Vinyl&format_exact=Album&genre_exact=Funk+%2F+Soul&limit=250&page=1
            // JAZZ - MOST COLLECTED - LPs/VINYL/ALBUM https://www.discogs.com/search/?sort=have%2Cdesc&format_exact=Vinyl&format_exact=LP&format_exact=Album&genre_exact=Jazz&page=1
            // POP - MOST COLLECTED - LPs/VINYL/ALBUM  https://www.discogs.com/search/?sort=have%2Cdesc&format_exact=Vinyl&format_exact=LP&format_exact=Album&genre_exact=Pop&page=1
            // HIP HOP - MOST COLLECTED - LPs/VINYL/ALBUM  https://www.discogs.com/search/?sort=have%2Cdesc&format_exact=LP&format_exact=Vinyl&format_exact=Album&genre_exact=Hip+Hop&limit=250&page=1            

            Console.WriteLine("");

            // CREATING SCRAPER
            DiscogsScraper Scraper = new DiscogsScraper()
            {
                startUrl = startUrl,
                genre = genre,
                numData = numData
            };

            Scraper.BeginScraping();

            Console.ReadLine();

        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            TextWriter LastExitLog = new StreamWriter(@"C:\Users\Kasper\Documents\code\Discogs_Scraper\LastExitLog.txt");
            LastExitLog.WriteLine("Hej");
            LastExitLog.Close();
            
        }
    }


}


