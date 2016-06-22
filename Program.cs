using Portsonic.Cppt.BizObjs.Core;
using System;

namespace Portsonic.Cppt
{
    public class Program
    {
        #region variable declarations
        private static Client _client;

        #endregion

        #region main

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Portsonic Communications, LLC");
                Console.WriteLine("CPPT Version 1.0");
                Console.WriteLine("Data Test Harness");
                Console.WriteLine("");
                Console.WriteLine("Initializing...");
                Initialize();
                Console.WriteLine("");
                Console.WriteLine("Press [Enter] to exit...");
                Console.Read();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        #endregion

        #region custom methods

        private static void Initialize()
        {
            try
            {
                //Initial out Client object
                _client = new Client();

                //Load our platform OS
                _client.LoadPlatformOS();

                Console.WriteLine("Application initialized successfully!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        #endregion
    }
}