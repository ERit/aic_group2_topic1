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

            // Step 2: Call the service operations.
            // Call the getStatisticValue operation
            double result = client.getStatisticValue();
            Console.WriteLine("Value: " + result);


            // just for testing purpose to watch the result of the getStatisticsValue method
            System.Threading.Thread.Sleep(10000); 
           

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();
        }
    }
}
