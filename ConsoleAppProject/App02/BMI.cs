using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMICalculator
    {
        public double Weight;
        public double Height;
        public double Output;

        public void App02Run()
        {
            Heading();
            Disclaimer();
            Input();
            Calc();
            OutputPrint();

        }
        public void Heading()
        {
            Console.WriteLine("\n                  APP 02                      ");
            Console.WriteLine("                  ------                      ");
            Console.WriteLine("Input your height and weight and the app outputs your BMI and comapres it " +
                "to the WHO catogories");
        }
        public void Disclaimer()
        {
            Console.WriteLine("\n!! BMI IS OUTDATED AND DOES NOT DISPLAY AN ACCURATE MEASUREMENTS OF HEALTH !!");
        }

        public void Input()
        {
            Console.WriteLine("\nEnter your weight in kg:");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in metres:");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void Calc()
        {
            Output = Weight / (Height * Height);
        }

        public void OutputPrint()
        {
            Console.WriteLine(Output);
        }

    }
}
