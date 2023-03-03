using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// this app will prompt the user to input a distance measured in one unit(fromUnit),
    /// and it will calculate 
    /// and output thedistance in another unit (toUnit)
    /// </summary>

    /// <author>
    /// kirandeep kaur 0.6
    /// </author>
    public class DistanceConverter
    {
        public void Run()
        {
            ConvertDistance();
        }
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// this method will input the distance in from unit
        /// calculate the same distance in to unit
        /// then output the distance in to unit
        /// </summary>

        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" please select the from distance unit >  ");
            toUnit   = SelectUnit(" please select the to distance unit >  ");
        
            Console.WriteLine($"\nConverting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"\n please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if(fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if(fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if(fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if(fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n you have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice =="2")
            {
                return MILES;
            }
            else if (choice.Equals("3"))
            {
                return METRES;
            }
            return null;
        }

        private static string DisplayChoices(String prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET}");
            Console.WriteLine($"2. {MILES}");
            Console.WriteLine($"3. {METRES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// prompt the user to enter the distance in any unit
        /// Input the unit as double number
        /// </summary>

        
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

         private void OutputDistance()
        {
            
            Console.WriteLine($"\n {fromDistance} {fromUnit}" + $" is {toDistance} {toUnit}!\n ");

        }

        /// <summary>
        /// ourput the discription of application
        /// and author name
        /// </summary>

        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("              Distance Converter            ");
            Console.WriteLine("              by Kirandeep kaur         ");
            Console.WriteLine("--------------------------------------------\n");
        }

    }
}
