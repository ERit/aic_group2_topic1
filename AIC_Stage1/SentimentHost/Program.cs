using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentLib;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SentimentHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 Create a URI to serve as the base address.
            Uri statAddress = new Uri("http://localhost:8000/Sentiment/Statistic");
            Uri authAddress = new Uri("http://localhost:8000/Sentiment/Authentication");
            Uri billAddress = new Uri("http://localhost:8000/Sentiment/Billing");

            // Step 2 Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(StatisticService), statAddress);
            ServiceHost authHost = new ServiceHost(typeof(Authenticator), authAddress);
            ServiceHost billHost = new ServiceHost(typeof(BillingService.BillingService), billAddress);

            try
            {
                // Step 3 Add a service endpoint.
                selfHost.AddServiceEndpoint(typeof(IStatistic), new WSHttpBinding(), "StatisticService");
                authHost.AddServiceEndpoint(typeof(IAuthenticator), new WSHttpBinding(), "AuthenticatorService");
                billHost.AddServiceEndpoint(typeof(BillingService.IBillingService), new WSHttpBinding(), "BillingService");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior smb1 = new ServiceMetadataBehavior();
                smb1.HttpGetEnabled = true;
                ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
                smb2.HttpGetEnabled = true;
                ServiceMetadataBehavior smb3 = new ServiceMetadataBehavior();
                smb3.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb1);
                authHost.Description.Behaviors.Add(smb2);
                billHost.Description.Behaviors.Add(smb3);

                // Step 5 Start the service.
                selfHost.Open();
                authHost.Open();
                billHost.Open();
                Console.WriteLine("The services are ready.");
                Console.WriteLine("Press <ENTER> to terminate services.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
                authHost.Close();
                billHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
                authHost.Abort();
                billHost.Abort();
            }

        }
    }
}
