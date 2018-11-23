using CoreLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        private static IDataConnection _dataConnection;


        static void Main(string[] args)
        {
            GlobalConfig.InitializeConnection();

            _dataConnection = GlobalConfig.DataConnection;

            DisplaySubmissions();

            Console.ReadLine();
        }

        private static void DisplaySubmissions()
        {
            var submissions = _dataConnection.GetSubmissions();

            foreach (var model in submissions)
            {
                Console.WriteLine($"{model.FileSpecification} : {model.DueDate}");
            }
        }
    }
}
