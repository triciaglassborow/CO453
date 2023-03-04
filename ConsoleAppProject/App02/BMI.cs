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
        string Input;
        public double Weight;
        public double Height;
        public double BMICalc;
        public string Output;
        const double UNDERWEIGHT = 18.49;
        const double NORMAL = 24.9;
        const double OVERWEIGHT = 29.9;
        const double OBESE_1 = 34.9;
        const double OBESE_2 = 39.9;

        public void App02Run()
        {
            Heading();
            Disclaimer();
            Select();
            Calc();
            Compare();
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

        public void Select()
        {
            Console.WriteLine("\nChoose the how you want to input your measurements: ");
            Console.WriteLine("1. Imperial");
            Console.WriteLine("2. Metric");
            Input = Console.ReadLine();
            if (Input == "1")
            {
                InputImperial();
            }
            else if (Input == "2")
            {
                InputMetric();
            }

            else
            {
                Console.WriteLine("\nPlease input the characters 1 or 2 only");
                Console.WriteLine("                            -----------");
                Select();
            }

        }
        public void InputImperial()
        {   
            Console.WriteLine("\nEnter your height in inches:");
           Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight in pounds:");
            Weight = Convert.ToDouble(Console.ReadLine());
            Weight = Weight * 703;
        }

    public void InputMetric()
        {   
            Console.WriteLine("\nEnter your height in metres:");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight in kg:");
            Weight = Convert.ToDouble(Console.ReadLine());
        }

        public void Calc()
        {
            BMICalc = Weight / (Height * Height);
        }

        public void Compare()
        {

            if (BMICalc <= OBESE_2)
            {
                Output = "Obese Class II";
            }

            if (BMICalc <= OBESE_1)
            {
                Output = "Obese Class I";
            }

            if (BMICalc <= OVERWEIGHT)
            {
                Output = "Overweight";
            }

            if (BMICalc <= NORMAL)
            {
                Output = "Normal";
            }
            
            if (BMICalc <= UNDERWEIGHT)
            {
                Output = "Underweight";
            }
            
            if (BMICalc > OBESE_2)
            {
                Output = "Obese Class III";
            }
        }

        public void OutputPrint()
        {
            Console.WriteLine("\nYour BMI is "+ BMICalc+ ", which puts you in the WHO category "+ Output);
        }

    }
}
