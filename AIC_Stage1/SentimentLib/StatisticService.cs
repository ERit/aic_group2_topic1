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
using System.Collections;

namespace SentimentLib
{
    public class StatisticService : IStatistic
    {
        private UserDao userdao;
        private string username;

        public StatisticService()
        {
            userdao = new UserDao();
        }

        /// <summary>
        /// returns the sentiment value for the given company
        /// </summary>
        /// <param name="companyname">name of the company</param>
        /// <returns>sentiment value</returns>
        public double getStatisticValue(string username)
        {
            this.username = username;
            Console.WriteLine("Statistic Service has been called.\n");
            return useSentiment140(getTweets(userdao.getCompanyFromUser(username)));
        }

        /// <summary>
        /// uses the tweetsharp api to get all tweets for the given company
        /// </summary>
        /// <param name="companyname">the name of the company</param>
        /// <returns>all tweets formated for the input string for the sentiment analysis</returns>
        private string getTweets(string companyname)
        {
            Console.WriteLine("Getting the tweets...");
            TwitterService twitterService = new TwitterService("H70mkcnY9uKDDGUcKywlBA", "fiobr6kG9OKwNHIU5D18dbpxWE5KdxWD8GRPRhMVII");
            OAuthAccessToken access = twitterService.GetAccessTokenWithXAuth("2012AIC", "!aicgroup");

            ArrayList pages = new ArrayList();
            JsonSerializer serializer = new JsonSerializer();

            int numPages = 5;

            // get the tweets from the first x numpages
            for (int i = 1; i <= numPages; i++)
            {
                if (companyname.Equals(""))
                    companyname = "aic_2012_statistico";
                TwitterSearchResult response = twitterService.Search(companyname, i, 100);
                RootObject page = (RootObject)serializer.Deserialize(new JsonTextReader(new StringReader(response.RawSource)), typeof(RootObject));
                pages.Add(page);
            }

            string result = "{'data': [";

            int count = 0;
            int eng = 0;

            foreach (RootObject curPage in pages)
            {
                foreach (var tweet in curPage.results)
                {
                    count++;
                    if (tweet.iso_language_code.Equals("en"))
                    {
                        eng++;
                        string tweettext = tweet.text;
                        tweettext = tweettext.Replace("\"", "");
                        tweettext = tweettext.Replace("\'", "");
                        tweettext = tweettext.Replace("\n", " ");

                        result += "{'text': '" + tweettext + "', 'query': '" + companyname + "'}, ";
                    }
                }
            }

            Console.WriteLine(count + " tweets fetched, " + eng + " were english and saved for the sentiment analysis.\n");

            // get rid of the last comma
            result = result.Substring(0, result.Length-2);
            result += "]}" ;
            return result;
        }


        /// <summary>
        /// uses the sentiment140 api to get the polarities and calculates the sentiment value
        /// </summary>
        /// <param name="tweets">string representation of the tweets</param>
        /// <returns>sentiment value between 0 and 1, where 0 is negative and 1 is positive</returns>
        private double useSentiment140(string tweets)
        {
            Console.WriteLine("Getting the sentiment analysis...");
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


        /// <summary>
        /// takes the output of the sentiment140 analysis and calculates the sentiment value
        /// </summary>
        /// <param name="result">the sentiment140 string</param>
        /// <returns>sentiment value</returns>
        private double get_percent(string result)
        {
            string[] split = result.Split(',');
            int positive = 0;
            int negative = 0;
            int neutral = 0;

            // 0: negative, 2: neutral, 4: positive
            foreach (string s in split)
            {
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

            double sentiment = (((double)positive * 1) + ((double)neutral * 0.5))
                / (double)(positive + negative + neutral);

            Console.WriteLine("Sentiment Analysis: " + String.Format("{0:0.##}", sentiment));

            userdao.addStatisticCall(username);

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
