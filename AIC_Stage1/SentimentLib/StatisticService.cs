using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TweetSharp;

namespace SentimentLib
{
    public class StatisticService : IStatistic
    {
        public double getStatisticValue(string companyname)
        {
            Console.WriteLine("Getting the tweets and starting the sentiment analysis ... Please wait...");

            return useSentiment140(getTweets("Microsoft"));
        }

        private string getTweets(string companyname)
        {
            // Twitter Username: 2012AIC, PW: !aicgroup
            TwitterService twitterService = new TwitterService("H70mkcnY9uKDDGUcKywlBA", "fiobr6kG9OKwNHIU5D18dbpxWE5KdxWD8GRPRhMVII");
            OAuthAccessToken access = twitterService.GetAccessTokenWithXAuth("2012AIC", "!aicgroup");

            TwitterSearchResult response = twitterService.Search(companyname, 10, 100);

            JObject newapiresults = null;
            newapiresults = JObject.Parse(response.RawSource);
            JArray tweets = new JArray();
            foreach (JObject status in tweets)
            {
                Console.WriteLine(status["text"]);
            }

            JsonSerializer serializer = new JsonSerializer();
            RootObject rootObject = (RootObject)serializer.Deserialize(new JsonTextReader(new StringReader(response.RawSource)), typeof(RootObject));

            string result = "";

            result += "{'data': [";

            foreach (var tweet in rootObject.results)
            {
                if (tweet.iso_language_code.Equals("en"))
                {
                    string tweettext = tweet.text;
                    tweettext = tweettext.Replace("\"", "");
                    tweettext = tweettext.Replace("\'", "");
                    tweettext = tweettext.Replace("\n", " ");

                    result += "{'text': '" + tweettext + "', 'query': '" + companyname + "'}, ";
                }
                    
            }

            // get rid of the last comma
            result = result.Substring(0, result.Length-2);

            result += "]}" ;

            return result;
        }





        private double useSentiment140(string tweets)
        {
            // using http://www.sentiment140.com/ for sentiment analysis	
            HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create("http://www.sentiment140.com/api/bulkClassifyJson");

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(tweets);

            httpWReq.Method = "POST";
            httpWReq.ContentType = "application/x-www-form-urlencoded";
            httpWReq.ContentLength = data.Length;
            Stream newStream;

            // sending the html post request to the sentiment140 server
            using (newStream = httpWReq.GetRequestStream())
            {
                newStream.Write(data, 0, data.Length);
            }

            string result = "";

            // get the response  
            using (HttpWebResponse response = httpWReq.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }

            newStream.Close();

            return get_percent(result);
        }


        /* 
		 * Polarity values are:
		 * 0: negative
		 * 2: neutral
		 * 4: positive
		*/
        private double get_percent(string result)
        {
            Console.WriteLine(result);

            string[] split = result.Split(',');

            int positive = 0;
            int negative = 0;
            int neutral = 0;

            foreach (string s in split)
            {

                // get polarity values
                if (s.Contains("polarity"))
                {
                    int polarity = Convert.ToInt32(s.Split(':')[1]);
                    if (polarity == 0)
                        negative++;
                    else if (polarity == 2)
                        neutral++;
                    else
                        positive++;
                }
            }
            Console.WriteLine("Negative tweets: " + negative);
            Console.WriteLine("Neutral tweets: " + neutral);
            Console.WriteLine("Positive tweets: " + positive);

            int all = positive + negative + neutral;

            double sentiment = (((double)positive * 1) + ((double)neutral * 0.5)) / (double)all;

            Console.WriteLine("Sentiment Analysis: " + String.Format("{0:0.##}", sentiment));

            // calculate percentage positive			
            return sentiment;
        }	

    }


    public class Url
    {
        public string url { get; set; }
        public string expanded_url { get; set; }
        public string display_url { get; set; }
        public int[] indices { get; set; }
    }

    public class Entities
    {
        public Url[] urls { get; set; }
    }

    public class Metadata
    {
        public int recent_retweets { get; set; }
        public string result_type { get; set; }
    }

    public class Result
    {
        public string created_at { get; set; }
        public Entities entities { get; set; }
        public string from_user { get; set; }
        public int from_user_id { get; set; }
        public string from_user_id_str { get; set; }
        public object geo { get; set; }
        public object id { get; set; }
        public string id_str { get; set; }
        public string iso_language_code { get; set; }
        public Metadata metadata { get; set; }
        public string profile_image_url { get; set; }
        public string source { get; set; }
        public string text { get; set; }
        public object to_user_id { get; set; }
        public object to_user_id_str { get; set; }
    }

    public class RootObject
    {
        public double completed_in { get; set; }
        public long max_id { get; set; }
        public string max_id_str { get; set; }
        public string next_page { get; set; }
        public int page { get; set; }
        public string query { get; set; }
        public string refresh_url { get; set; }
        public Result[] results { get; set; }
        public int results_per_page { get; set; }
        public int since_id { get; set; }
        public string since_id_str { get; set; }
    }
}
