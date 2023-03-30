using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    public class NewsFeed
    {
        public string Username;
        public string Text;
        public string Caption;
        public string File;
        public string Input;

        public string Test;
       
        public void App04Run()
        {
            //header
            Login();
            Selection();
        }

        public void Login()
        {
            Console.WriteLine("Enter Username:");
            Username = Console.ReadLine();
        }

        public void Selection()
        {
            Console.WriteLine("What do you want to do? \n1. Post a message \n2. Post a photo");
            Input = Console.ReadLine();

            if(Input == "1")
            {
                TextPost();
            }

            if(Input == "2")
            {
                PhotoPost();
            }
                
        }

        public void TextPost()
        {
            Test = "TEXTPOST";
            Console.WriteLine("Enter message: ");
            Text = Console.ReadLine();

            MessagePost getMessagePost = new MessagePost(Username, Text);
            getMessagePost.Display();
        }

        public void PhotoPost()
        {
            Test = "PHOTOPOST";
            Console.WriteLine("Enter file name:");
            File = Console.ReadLine();

            Console.WriteLine("Enter caption:");
            Caption = Console.ReadLine();

            PhotoPost getPhotoPost = new PhotoPost(Username, File, Caption);
            getPhotoPost.Display();
        }
        
    }

}
