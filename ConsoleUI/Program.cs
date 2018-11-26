using CoreLibrary;
using System;
using CoreLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        private static IDataConnection _dataConnection;


        static void Main(string[] args)
        {
            GlobalConfig.InitializeConnection();
            _dataConnection = GlobalConfig.DataConnection;

            //DisplaySubmissions();

            SubmissionModel submission = new SubmissionModel("045");

            Console.WriteLine(submission.CurrentState());

            submission.SubmissionState.Complete();

            Console.WriteLine(submission.CurrentState());

            Console.ReadLine();
        }

        private static void DisplaySubmissions()
        {
            var submissions = _dataConnection.GetSubmissions();

            foreach (var model in submissions)
            {
                Console.WriteLine($"{model.FileSpecification} : {model.DueDate} : {model.AssignedUser} : {model.SubmissionState}");
            }
        }
    }
}
