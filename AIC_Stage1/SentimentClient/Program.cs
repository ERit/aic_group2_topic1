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

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Statistiko!");
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine();

                Console.WriteLine("1) Login");
                Console.WriteLine("2) Register");
                Console.WriteLine("3) Quit");

                Console.WriteLine();
                string firstInput = Console.ReadLine();

                if (firstInput.Equals("1"))
                {
                    Console.Clear();

                        Console.WriteLine("Please Login!");
                        Console.Write("Username: ");
                        string username = Console.ReadLine();

                        Console.Write("Passwort: ");
                        string password = Orb.App.Console.ReadPassword('*');

                        if (auth.validateLogin(username, password))
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome " + username + " !");
                                Console.WriteLine();
                                Console.WriteLine("1) Want to see the actual statistics for your company?");
                                Console.WriteLine("2) Do you want to watch your bills?");
                                Console.WriteLine("3) Unregister");
                                Console.WriteLine("4) Logout");
                                Console.WriteLine();
                                string secondInput = Console.ReadLine();

                                if (secondInput.Equals("1"))
                                {
                                    double result = client.getStatisticValue(auth.getCompanyFromUsername(username));
                                    Console.WriteLine("Sentiment Analysis for " + auth.getCompanyFromUsername(username) +
                                        ": " + String.Format("{0:0.##}", result));

                                    Console.ReadLine();
                                }
                                else if (secondInput.Equals("2"))
                                {
                                    //TODO
                                }
                                else if (secondInput.Equals("3"))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Do you really want to unregister? (yes/no)");
                                    Console.WriteLine();
                                    string unregisterInput = Console.ReadLine();

                                    if (unregisterInput.Equals("yes"))
                                    {
                                        auth.unregister(username);
                                        Console.WriteLine("Good bye!");
                                        Console.ReadLine();
                                        break;
                                    }
                                }
                                else if (secondInput.Equals("4"))
                                {
                                    Console.WriteLine("Good bye!");
                                    Console.ReadLine();
                                    break;
                                }
                            }


                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong user credentials. Please try again!");
                            Console.ReadLine();
                        }
             
                }
                else if (firstInput.Equals("2"))
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the registration form. Please answer the following questions:");
                    Console.WriteLine();
                    Console.Write("Whats your first name? -> ");
                    string firstname = Console.ReadLine();
                    Console.Write("Whats your last name? -> ");
                    string lastname = Console.ReadLine();
                    Console.Write("Please enter a nickname -> ");
                    string name = Console.ReadLine();
                    Console.Write("Please enter a password -> ");
                    string passwd = Orb.App.Console.ReadPassword('*');
                    Console.Write("Please enter your password again -> ");
                    string passwd2 = Orb.App.Console.ReadPassword('*');


                    if (passwd.Equals(passwd2))
                    {
                        Console.Write("Enter your email -> ");
                        string email = Console.ReadLine();
                        Console.Write("Enter your creditcard number -> ");
                        string creditcard = Console.ReadLine();
                        Console.Write("Enter your company name -> ");
                        string company = Console.ReadLine();

                        if (name.Length > 0 &&
                            passwd.Length > 0 &&
                            passwd2.Length > 0 &&
                            firstname.Length > 0 &&
                            lastname.Length > 0 &&
                            email.Length > 0 &&
                            creditcard.Length > 0 &&
                            company.Length > 0 &&
                            auth.register(name, passwd, firstname, lastname, email, creditcard, company))
                        {
                            Console.WriteLine("Thank you for your registration! Please log in.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Please enter correct data. Try again.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Passwords not matching. Try again ...");
                        Console.ReadLine();
                    }
                }
                else if (firstInput.Equals("3"))
                {
                    Console.WriteLine("Good bye!");
                    Console.WriteLine("Press <ENTER> to terminate service.");
                    Console.ReadLine();
                    break;
                }
            }

            client.Close();
            auth.Close();
        }
    }
}

namespace Orb.App
{
    /// <summary>
    /// Adds some nice help to the console. Static extension methods don't exist (probably for a good reason) so the next best thing is congruent naming.
    /// </summary>
    static public class Console
    {
        /// <summary>
        /// Like System.Console.ReadLine(), only with a mask.
        /// </summary>
        /// <param name="mask">a <c>char</c> representing your choice of console mask</param>
        /// <returns>the string the user typed in </returns>
        public static string ReadPassword(char mask)
        {
            const int ENTER = 13, BACKSP = 8, CTRLBACKSP = 127;
            int[] FILTERED = { 0, 27, 9, 10 /*, 32 space, if you care */ }; // const

            var pass = new Stack<char>();
            char chr = (char)0;

            while ((chr = System.Console.ReadKey(true).KeyChar) != ENTER)
            {
                if (chr == BACKSP)
                {
                    if (pass.Count > 0)
                    {
                        System.Console.Write("\b \b");
                        pass.Pop();
                    }
                }
                else if (chr == CTRLBACKSP)
                {
                    while (pass.Count > 0)
                    {
                        System.Console.Write("\b \b");
                        pass.Pop();
                    }
                }
                else if (FILTERED.Count(x => chr == x) > 0) { }
                else
                {
                    pass.Push((char)chr);
                    System.Console.Write(mask);
                }
            }

            System.Console.WriteLine();

            return new string(pass.Reverse().ToArray());
        }

        /// <summary>
        /// Like System.Console.ReadLine(), only with a mask.
        /// </summary>
        /// <returns>the string the user typed in </returns>
        public static string ReadPassword()
        {
            return Orb.App.Console.ReadPassword('*');
        }
    }
}
