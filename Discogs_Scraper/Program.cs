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
            string startUrl = @"https://www.discogs.com/search/?limit=250&sort=have%2Cdesc&format_exact%5B0%5D%5B%5D=Vinyl&format_exact%5B0%5D%5B%5D=LP&format_exact%5B%5D=Album&genre_exact=Pop&page=1";
            string genre = "Pop";
            int numData = 10000;

            // FUNK - MOST COLLECTED - LPs/VINYL/ALBUM https://www.discogs.com/search/?sort=have%2Cdesc&format_exact=LP&format_exact=Vinyl&format_exact=Album&genre_exact=Funk+%2F+Soul&limit=250&page=1
            // JAZZ - MOST COLLECTED - LPs/VINYL/ALBUM https://www.discogs.com/search/?sort=have%2Cdesc&format_exact=Vinyl&format_exact=LP&format_exact=Album&genre_exact=Jazz&page=1
            // POP - MOST COLLECTED - LPs/VINYL/ALBUM  https://www.discogs.com/search/?limit=250&sort=have%2Cdesc&format_exact%5B0%5D%5B%5D=Vinyl&format_exact%5B0%5D%5B%5D=LP&format_exact%5B%5D=Album&genre_exact=Pop&page=1
            // HIP HOP - MOST COLLECTED - LPs/VINYL/ALBUM  https://www.discogs.com/search/?sort=have%2Cdesc&format_exact=LP&format_exact=Vinyl&format_exact=Album&genre_exact=Hip+Hop&limit=250&page=1            


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
    }


}


