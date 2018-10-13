using System;
using System.IO;
using HtmlAgilityPack;

namespace Discogs_Scraper
{
    class DiscogsScraper
    {
        // PROPERTIES
        public string startUrl; // Page to start scraping from.
        public int numData; // Number of data instances to collect.

        //CONSTRUCTER
        public DiscogsScraper(string startUrl = "", int numData = 0)
        {
            this.startUrl = startUrl;
            this.numData = numData;
        }

        public void BeginScraping()
        {
            Console.WriteLine("Begin Scraping..");
            CreateListingLinks(); // Get listing page links and stores them in listingLinks.txt
            GetReleaseLinks();

        }

        private void GetReleaseLinks()
        {
            TextReader tr = new StreamReader(@"C:\Users\Kasper\Documents\code\Discogs_Scraper\listingLinks.txt");
            TextWriter tw = new StreamWriter(@"C:\Users\Kasper\Documents\code\Discogs_Scraper\releaseLinks.txt");
            string currentlyProcessedLink;
            
            for (int i = 1; i <= numData/250; i++)
            {
                currentlyProcessedLink = tr.ReadLine();
                try
                {
                    HtmlDocument doc = GetHtmlDoc(currentlyProcessedLink);

                    // ********************************************** IMPLEMENT THIS NEXT TIME **************************************************************
                    List<string> allLinks = new List<string>();
                    foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                    {
                        HtmlAttribute att = link.Attributes["href"];
                        //Console.WriteLine(att.Value);
                        allLinks.Add(att.Value);
                    }



                    // Loop through allLinks, filters out non-release links
                    foreach (string link in allLinks)
                    {
                        string[] stringSplit = link.Split('/');
                        int end_value;
                        bool succes = Int32.TryParse(stringSplit[stringSplit.Length - 1], out end_value);
                        if (succes)
                        {
                            releaseLinks.Add(link);
                        }
                    }
                    //***************************************************************************************************************************************

                }
                catch (System.Net.WebException)
                {
                    i = i - 1; //if fail, go back 1 i.
                    continue;
                }
                

            }

            tr.Close();


        }

        private HtmlDocument GetHtmlDoc(string url)
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load(url);

            return doc;
        }

        private void CreateListingLinks()
        {
            //Function: creates number of listing-pages needed to scrape numData links. The links are saved to a file as they are obtained.

            Console.WriteLine("Creating listing links.."); // User message
            int numPages = numData / 250; // Calculates the number of listingpages to scrape to achieve numData datapoints. (Assumes that one listing page has 250 releases)
            int lastIndex = startUrl.Length - 1; 
            startUrl = startUrl.Remove(lastIndex, 1) + "{0}";

            TextWriter tw = new StreamWriter(@"C:\Users\Kasper\Documents\code\Discogs_Scraper\listingLinks.txt");
            for (int i = 1; i <= numPages; i++ ) // Create urls
            {
                string url = string.Format(startUrl, i);
                tw.WriteLine(url);
                
            }

            tw.Close();

        }
    }
}




//private bool CheckForSingleGenre()
//{
//    Console.WriteLine("Checking if the release has a single or multiple genres.");
//}

// DiscogsScraper Method: GetHtml();
// DiscogsScraper Method: GetReleaseLinks();
// DiscogsScraper Method: DownloadImage();
// DiscogsScraper Method: DetectNumberOfReleasesOnListingPage();


// Release Method: Release.CheckForSingleGenre();
// Release Method: Release.GetData();

