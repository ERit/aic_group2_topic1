using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentClient.StatisticServiceReference;

namespace SentimentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Create an instance of the WCF proxy.
            StatisticClient client = new StatisticClient();

            Console.WriteLine("Client running and calling host...");

            // Step 2: Call the service operations.
            // Call the getStatisticValue operation
            string companyName = "Logitech";
            double result = client.getStatisticValue(companyName);
            Console.WriteLine("Sentiment Analysis for " + companyName + ": " + String.Format("{0:0.##}", result));

            Console.WriteLine("Press <ENTER> to terminate service.");
            Console.WriteLine();
            Console.ReadLine();


            // just for testing purpose to watch the result of the getStatisticsValue method
            //System.Threading.Thread.Sleep(10000); 
           

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();
        }
    }
}
