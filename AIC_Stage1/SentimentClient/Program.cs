using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentClient.StatServiceReference;
using SentimentClient.AuthServiceReference;

namespace SentimentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Create an instance of the WCF proxy.
            StatisticClient client = new StatisticClient();
            AuthenticatorClient auth = new AuthenticatorClient();

            Console.WriteLine("Client running and calling host...");

            // Step 2: Call the service operations.
            // Call the getStatisticValue operation
            while (true)
            {
                Console.WriteLine("Please Login!");
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Passwort: ");
                string password = Console.ReadLine();

                if (auth.validateLogin(username, password))
                {
                    double result = client.getStatisticValue(auth.getCompanyFromUsername(username));
                    Console.WriteLine("Sentiment Analysis for " + auth.getCompanyFromUsername(username) + ": " + String.Format("{0:0.##}", result));

                    break;
                }
                else
                {
                    Console.WriteLine("Wrong user credentials. Please try again!");
                }
            }

            Console.WriteLine("Press <ENTER> to terminate service.");
            Console.WriteLine();
            Console.ReadLine();


            // just for testing purpose to watch the result of the getStatisticsValue method
            //System.Threading.Thread.Sleep(10000); 
           

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();
            auth.Close();
        }
    }
}
