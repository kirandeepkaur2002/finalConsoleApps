using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// this app will prompt the user to input a distance in feet, miles or metres
    /// and will convert this into the other units
    /// </summary>

    /// <author>
    /// kirandeep kaur 0.3
    /// </author>
    public class DistanceConverter
    {
        public void Run()
        {
            MilesToFeet();
            FeetToMiles();
            MilesToMetres();
        }
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        /// this method will input the distance measured in miles
        /// calculate the same distance in feet
        /// then output the distance in feet
        /// </summary>

        public void MilesToFeet()
        {
            OutputHeading("Converting miles to feet");

            miles = InputDistance("please enter the number of miles");
            CalculateFeet();
            OutputDistance(miles, nameof (miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting feet to miles");

            feet = InputDistance("please enter the number of feet");
            CalculateMiles();
            OutputDistance(feet, nameof (feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting miles to metres");

            miles = InputDistance("please enter the number of miles");
            CalculateMetres();
            OutputDistance(miles, nameof (miles), metres, nameof(metres));
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
        
        


        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputDistance(double fromDistance, 
          string fromUnit,
         double toDistance, string toUnit)
        {
            Console.WriteLine($"{fromDistance} {fromUnit}" + $" is {toDistance} {toUnit}!");

        }

         

        /// <summary>
        /// ourput the discription of application
        /// and author name
        /// </summary>

        private void OutputHeading(string prompt)
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("              Distance Converter            ");
            Console.WriteLine("              by Kirandeep kaur         ");
            Console.WriteLine("--------------------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

    }
}
