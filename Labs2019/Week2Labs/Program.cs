using System;
using System.Net;
using System.IO;
namespace Week2Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("everything is commented out on purpose, I didn't want this mess on my Github but oh well");
            // DateTime today = DateTime.Now;
            // Console.WriteLine(today);
            // Console.WriteLine(DateTime.Now.ToString("MMMM"));
            // Console.ReadLine();
            /*string hipsterIpsum = "Lorem ipsum dolor amet exercitation yuccie 8-bit, distillery consectetur hashtag copper mug tilde meditation man bun shaman master cleanse 90's leggings ennui. Tousled eu laborum, tumeric mollit 90's occupy meditation echo park ut tilde shaman. Labore cardigan dolore affogato poutine. Wayfarers cloud bread leggings, banjo bitters poke DIY do cliche polaroid et lo-fi. Tacos scenester letterpress, sed occaecat sriracha post-ironic ex bushwick ullamco.";
            string[] hipster = hipsterIpsum.Split();

            Console.WriteLine("{0,5}{1, 15}{2,15}", hipster[0], hipster[1], hipster[2]);

            string year = today.ToString("Y");

            string month = today.ToString("MMMM");
            string day = today.ToString("dd");

            string name = "Sam Kaiser";
            string address = "42 Wallaby Way, Sydney Australia";

            Console.WriteLine($"{name}\n{address}");
            Console.ReadLine();*/
           /* string todayIs = String.Format("{0}{1}, {2}", day, month, year);
            Console.WriteLine(todayIs);
            Console.WriteLine(today.ToString("dd-MM-yyyy"));
            Console.WriteLine(today.ToString("d"));
            Console.WriteLine(today.ToString("D"));
            Console.WriteLine(today.ToString("M"));
            Console.WriteLine("Day {0} of {1}, {2}", day, month, year );
            

            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            Console.WriteLine(unixTimestamp);Console.ReadLine();*/
            /*string html = string.Empty;
            string url = @"https://jsonplaceholder.typicode.com/todos/1";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }


            Console.WriteLine(html);

            Console.ReadLine();*/

        }
    }
}
