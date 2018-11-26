using CoreLibrary;
using System;
using System.Collections.Generic;
using CoreLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        private static IDataConnection _dataConnection;
        private static List<SubmissionModel> submissions; 

        static void Main(string[] args)
        {
            GlobalConfig.InitializeConnection();
            _dataConnection = GlobalConfig.DataConnection;

            LoadSubmissions();
            DisplaySubmissions(submissions);



            //SubmissionModel submission = new SubmissionModel("045");

            //Console.WriteLine($"Current State: {submission.CurrentState()}");

            //submission.State.Complete();

            //Console.WriteLine($"Current State: {submission.CurrentState()}");

            //submission.State.Complete();

            //Console.WriteLine($"Current State: {submission.CurrentState()}");


            Console.WriteLine("Finished ");
            Console.ReadLine();
        }

        private static void LoadSubmissions()
        {
            submissions = _dataConnection.GetSubmissions();
            
        }

        private static void DisplaySubmissions(List<SubmissionModel> submissions)
        {
           
            foreach (var model in submissions)
            {
                Console.WriteLine($"{model.FileSpecification} : {model.DueDate} : {model.AssignedUser} : {model.CurrentState()}");
            }
        }
    }
}
