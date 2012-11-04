using System;
using System.Net;
using System.Web;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;
using System.Runtime;
using System.Text;

namespace aic_topic1_stage1
{
	public class GetStatistic
	{
		private string name;
		
		public GetStatistic (String name)
		{		
			// Twitter Username: 2012AIC, PW: !aicgroup
			this.name = name;
			Console.WriteLine(this.name);
			getData();
		}
		
		public void getData()
		{					
			// using http://www.sentiment140.com/ for sentiment analysis	
			// TODO: get the tweets for the firm and send them instead of this test string
			string test = "{'data': [{'text': 'I love Titanic.', 'query': 'Titanic', 'topic': 'movies'}, " +
				"{'text': 'I hate Titanic.', 'query': 'Titanic', 'topic': 'movies'}]}";
			    
			HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create("http://www.sentiment140.com/api/bulkClassifyJson");
			
			ASCIIEncoding encoding = new ASCIIEncoding();
			byte[] data = encoding.GetBytes(test);
			
			httpWReq.Method = "POST";
			httpWReq.ContentType = "application/x-www-form-urlencoded";
			httpWReq.ContentLength = data.Length;
			Stream newStream;
			
			// sending the html post request to the sentiment140 server
			using (newStream = httpWReq.GetRequestStream())
			{
			    newStream.Write(data,0,data.Length);
			}
			
		    string result = "";  
			
			// get the response  
	        using (HttpWebResponse response = httpWReq.GetResponse() as HttpWebResponse)  
	        {  
	            StreamReader reader = new StreamReader(response.GetResponseStream());  
	            result = reader.ReadToEnd();  
	        }  
			
			Console.WriteLine("Positive Percentage: " + get_percent(result));

			newStream.Close();
		}
		
		
		/* 
		 * Polarity values are:
		 * 0: negative
		 * 2: neutral
		 * 4: positive
		*/	
		public float get_percent(string result) 
		{
			Console.WriteLine(result);
			// {"data":[{"topic":"movies","text":"I love Titanic.","polarity":4,"query":"Titanic","meta":{"topic":"movies","language":"en"}},{"topic":"movies","text":"I hate Titanic.","polarity":0,"query":"Titanic","meta":{"language":"en"}}]}
			
			string [] split = result.Split(',');
			
			int positive = 0;
			int negative = 0;

	        foreach (string s in split) {
	
				// get polarity values
	            if (s.Contains("polarity"))
				{
	                if (Convert.ToInt32(s.Split(':')[1]) == 0)
						negative++;
					else
						positive++;					
				}	
	        }
			Console.WriteLine("Positive tweets: " + positive);
			Console.WriteLine("Negative tweets: " + negative);
			int all = positive + negative;
			
			// calculate percentage positive			
			return (float)positive/(float)all*100;
		}	
	}
}

