using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the BMI Calculator :)");

            double weight = GetWeight();
            double height = GetHeight();

            double BMI = calculateBMI(weight, height);
            Console.WriteLine("Your final BMI is: " + Math.Round(BMI, 2));
        }

        static double GetWeight()
        {
            Console.WriteLine("Enter your weight in kilograms: ");
            double weight = Double.Parse(Console.ReadLine());
            return weight;
        }

        static double GetHeight()
        {
            Console.WriteLine("Enter your height in centimeters: " );
            double height = Double.Parse(Console.ReadLine());
            return height;
        }
        
        static double calculateBMI(double weight, double height)
        {
            // Calculator
            double bmi = weight / Math.Pow(height, 2)*10000;
            return bmi;
        }
           
    }
}