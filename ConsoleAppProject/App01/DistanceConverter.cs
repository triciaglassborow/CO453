using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Tricia Glassborow
    /// </author>

    public class DistanceConverter
    {
        const int NUMBER_OF_FEET = 5280;
        public double Input;
        public string InputUnits;
        public double Output;
        public string OutputUnits;


        
        public void Run()
        {
            Console.WriteLine("                  APP 01                      ");
            Console.WriteLine("                  ------                      ");

            Console.WriteLine("What are you converting FROM? ");
            Console.WriteLine("\n1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("\nEnter 1 or 2");
            int select = Convert.ToInt32(Console.ReadLine());
            if (select == 1)
            {
                FeetToMiles();
            }
            if (select == 2)
            {
                MilesToFeet();
            }

            OutputPrint();
        }        


        ///conversions
        public void FeetToMiles()
        {
            Console.WriteLine("\nEnter number of feet: ");
            Input = Convert.ToDouble(Console.ReadLine());

            Output = Input / NUMBER_OF_FEET;

            ///asigning units
            if (Input == 1)
            {
                InputUnits = " Foot";
            }
            else
            {
                InputUnits = " Feet";
            }
            
            if (Output == 1)
            {
                OutputUnits = " Mile";
            }
            else
            {
                OutputUnits = " Miles";
            }
        }

        public void MilesToFeet()
        {
            Console.WriteLine("\nEnter number of miles: ");
            Input = Convert.ToDouble(Console.ReadLine());

            Output = Input * NUMBER_OF_FEET;

            ///asigning units
            if (Input == 1)
            {
                InputUnits = " Mile";
            }
            else
            {
                InputUnits = " Miles";
            }

            if (Output == 1)
            {
                OutputUnits = " Foot";
            }
            else
            {
                OutputUnits = " Feet";
            }
        }


        ///output
        public void OutputPrint()
        {
            Console.WriteLine("");
            Console.WriteLine(Input + InputUnits + " converts to " + Output + OutputUnits );
        }
    }
}
