using System;
using ConsoleAppProject.App01;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// this app will prompt the user to enter his weight and height
    /// and then app will calculate BMI and output BMI
    /// with an advice
    /// </summary>
    /// <author>
    /// kirandeep kaur version 0.2
    /// </author>
    public class BMI
    {
        public void Run()
        {
           BMIcalculater();
        }

        private int Weight ;
        private int Height;
        private int stones;
        private int pounds;
        private int feet;
        private int inches;

        private int Height1;
        private int Weight1;

        public int CalcBMI { get; private set; }
        public static string cs { get; private set; }
        /// <summarry>
        /// method to prompt the user to enter weight in
        /// stones and pounds and height in
        /// feet and inches
        /// </summarry>

        public void BMIcalculater()
        {
            OutputHeading();

           Weight  = (int)InputWeight($"\n please enter your weight in stones > ");
           Weight1  = (int)InputWeight($"\n please enter your weight in pounds > ");
           Height   = (int)InputHeight($"\n please enter your height feet > ");
           Height1 = (int)InputHeight($"\n please enter your height inches > ");
           
           CalculateBMI();
           OutputBMI();
        }

        private void OutputBMI()
        {
            Console.WriteLine(" your BMI is ");
        }

        private object InputHeight(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        private object InputWeight(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        private void CalculateBMI()
        {
           CalcBMI = ((Weight * 14 + Weight1) * 703) / ((Height * 12 + Height1) * (Height * 12 + Height1));
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {            
                return DistanceConverter.cs;
            }
            else if (choice =="2")
            {
                return BMI.cs;
            }
            return null;
        }

        ///<summarry>
        /// adding code to display the
        /// choices beytween two apps
        /// </summary> 

        private static string DisplayChoices(String prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {DistanceConverter.cs}");
            Console.WriteLine($"2. {BMI.cs}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("              Distance Converter            ");
            Console.WriteLine("              by Kirandeep kaur         ");
            Console.WriteLine("--------------------------------------------\n");
        }
        
    }
}
