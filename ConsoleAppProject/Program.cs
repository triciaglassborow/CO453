using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static string Username;
        public static string Text;
        public static string Caption;
        public static string File;
        
        public static NewsFeed newsFeed;


        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("   BNU CO453 Applications Programming 2023    ");
            Console.WriteLine("                                 by Tricia    ");
            Console.WriteLine("==============================================");
            Console.WriteLine();

            //DistanceConverter converter = new DistanceConverter();
            //converter.App01Run();


            //BMICalculator GetBMICalculator = new BMICalculator();
            //GetBMICalculator.App02Run();

            //StudentGrades GetStudentGrades = new StudentGrades();
            //GetStudentGrades.App03Run();

            newsFeed = new NewsFeed();
            App04Run();

        
        }

        public static void App04Run()
        {
            //header
            Login();
            Selection();
            
        }

        public static void Login()
        {
            Console.WriteLine("Enter Username:");
            Username = Console.ReadLine();
        }

        public static void Selection()
        {
            Console.WriteLine("What do you want to do? \n1. Post a message \n2. Post a photo" +
                "\n3. View Feed \n4. Display by username");
            string Input = Console.ReadLine();

            if (Input == "1")
            {
                TextPost();
            }

            if (Input == "2")
            {
                PhotoPost();
            }

            if (Input == "3")
            {
                DisplayFeed();
            }

            if (Input == "4")
            {
                DisplayByUsername();
            }

            if (Input == "5")
            {

            }

        }

        public static void TextPost()
        {
            Console.WriteLine("Enter message: ");
            Text = Console.ReadLine();

            MessagePost getMessagePost = new MessagePost(Username, Text);
            getMessagePost.Display();

            newsFeed.AddMessagePost(getMessagePost);

            Selection();
        }

        public static void PhotoPost()
        {
            Console.WriteLine("Enter file name:");
            File = Console.ReadLine();

            Console.WriteLine("Enter caption:");
            Caption = Console.ReadLine();

            PhotoPost getPhotoPost = new PhotoPost(Username, File, Caption);
            getPhotoPost.Display();

            newsFeed.AddPhotoPost(getPhotoPost);

            Selection();
        }

        public static void DisplayFeed()
        {
            newsFeed.Display();
        }

        public static void DisplayByUsername()
        {
            Console.WriteLine("What users profile would you like to see?");
            string name = Console.ReadLine();
            foreach (MessagePost message in newsFeed.messages)
            {
                if(name == message.Username)
                {
                    message.Display();
                    Console.WriteLine();   // empty line between posts
                }                
            }

            foreach (PhotoPost photo in newsFeed.photos)
            {
                if (name == photo.Username)
                {
                    photo.Display();
                    Console.WriteLine();   // empty line between posts
                }
            }
        } 

        public static void AddComment()
        {

        }
    }
}
