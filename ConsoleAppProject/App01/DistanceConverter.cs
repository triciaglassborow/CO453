﻿using System;

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
        

        const double NUMBER_OF_FEET = 5280;
        const double NUMBER_OF_METRES = 1609.34;

        public int InputSelected;
        public int OutputSelected;
        public int UniversalOutputSelected;
        //feet = 1
        //miles = 2
        // metres = 3
        
        public double Input;
        public string InputUnits;

        public double Output;
        public string OutputUnits;



        
        public void App01Run()
        {  
            Heading();
            InputSelect();           
            OutputSelect();          
            OutUnits();
            OutputPrint();
        }

        public void Heading()
        {
            Console.WriteLine("                  APP 01                      ");
            Console.WriteLine("                  ------                      ");
        }

        //user selecting what units they are converting from
        public void InputSelect()
        {
            Console.WriteLine("What are you converting FROM?\n");
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Metres");
            Console.WriteLine("\nEnter 1, 2 or 3: ");
            InputSelected  = Convert.ToInt32(Console.ReadLine());
            InUnits();
        }

        public void OutputSelect()
        {
            if (InputSelected == 1)// input = feet
            {
                Console.WriteLine("\nWhat are you converting TOO? ");
                Console.WriteLine("\n1. Miles");
                Console.WriteLine("2. Metres");
                Console.WriteLine("\nEnter 1 or 2");
                OutputSelected = Convert.ToInt32(Console.ReadLine());
                
            }

            if (InputSelected == 2)//input = miles
            {
                Console.WriteLine("\nWhat are you converting TOO? ");
                Console.WriteLine("\n1. Feet");
                Console.WriteLine("2. Metres");
                Console.WriteLine("\nEnter 1 or 2");
                OutputSelected = Convert.ToInt32(Console.ReadLine());
            }

            if (InputSelected == 3)//input = metres
            {
                Console.WriteLine("\nWhat are you converting TOO? ");
                Console.WriteLine("\n1. Feet");
                Console.WriteLine("2. Miles");
                Console.WriteLine("\nEnter 1 or 2");
                OutputSelected = Convert.ToInt32(Console.ReadLine());
            }
            Conversions();


        }

        public void Conversions()
        {            
            if (InputSelected == 1) //input = feet
            {
                if (OutputSelected == 1) //convert to miles
                {
                    Output = Input / NUMBER_OF_FEET;
                    UniversalOutputSelected = 2;
                }
                else if (OutputSelected == 2) //convert to metres
                {
                    Output = Input / NUMBER_OF_FEET; //feet -> miles
                    Output = Output * NUMBER_OF_METRES; //miles -> metres
                    UniversalOutputSelected = 3;
                }
                else
                {
                    Console.WriteLine("\nPlease input the characters 1 or 2 only");
                    Console.WriteLine("                            -----------");
                    OutputSelect();
                }
            }
            if (InputSelected == 2) //input = miles 
            {
                if (OutputSelected == 1) //convert to feet
                {
                    Output = Input * NUMBER_OF_FEET;
                    UniversalOutputSelected = 1;
                }
                else if (OutputSelected == 2) //convert to metres
                {
                    Output = Input * NUMBER_OF_METRES; //miles -> metres
                    UniversalOutputSelected = 3;    
                }
                else
                {
                    Console.WriteLine("\nPlease input the characters 1 or 2 only");
                    Console.WriteLine("                            -----------");
                    OutputSelect();
                }
            }

            if (InputSelected == 3) //input = metres 
            {
                if (OutputSelected == 1) //convert to feet
                {
                    Output = Input / NUMBER_OF_METRES; //metres -> miles
                    Output = Output * NUMBER_OF_FEET;// miles -> feet
                    UniversalOutputSelected = 1;
                }
                else if (OutputSelected == 2) //convert to miles
                {
                    Output = Input / NUMBER_OF_METRES;
                    UniversalOutputSelected = 2;
                }
                else
                {
                    Console.WriteLine("\nPlease input the characters 1 or 2 only");
                    Console.WriteLine("                            -----------");
                    OutputSelect();
                }
            }
        }

        public void InUnits()
        {
            //input
            if (InputSelected == 1) //input = feet
            {
                Console.WriteLine("\nEnter number of feet: ");
                Input = Convert.ToDouble(Console.ReadLine());
                if (Input == 1)
                {
                    InputUnits = " Foot";
                }
                else
                {
                    InputUnits = " Feet";
                }
            }

            else if (InputSelected == 2) //input = miles
            {
                Console.WriteLine("\nEnter number of miles: ");
                Input = Convert.ToDouble(Console.ReadLine());
                if (Input == 1)
                {
                    InputUnits = " Miles";
                }
                else
                {
                    InputUnits = " Miles";
                }
            }

            else if (InputSelected == 3) //input = metres
            {
                Console.WriteLine("\nEnter number of metres: ");
                Input = Convert.ToDouble(Console.ReadLine());
                if (Input == 1)
                {
                    InputUnits = " Metre";
                }
                else
                {
                    InputUnits = " Metres";
                }
            }

            else
            {
                Console.WriteLine("\nPlease input the characters 1, 2 or 3 only");
                Console.WriteLine("                            --------------");
                InputSelect();
            }
        }

        public void OutUnits()
        {
            //output
            if (UniversalOutputSelected == 1) //Output = feet
            {                
                if (Output == 1)
                {
                    OutputUnits = " Foot";
                }
                else
                {
                    OutputUnits = " Feet";
                }
            }

            else if (UniversalOutputSelected == 2) //Output = miles
            {
                if (Output == 1)
                {
                    OutputUnits = " Mile";
                }
                else
                {
                   OutputUnits = " Miles";
                }
            }

            else if (UniversalOutputSelected == 3) //Output = metres
            {
                if (Output == 1)
                {
                    OutputUnits = " Metre";
                }
                else
                {
                   OutputUnits = " Metres";
                }
            }

            
        }

        ///terminal output
        public void OutputPrint()
        {            
            Console.WriteLine("");
            Console.WriteLine(Input + InputUnits + " converts to " + Output + OutputUnits);
        }
    }
}
