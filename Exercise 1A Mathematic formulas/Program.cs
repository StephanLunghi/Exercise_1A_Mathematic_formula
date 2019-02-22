using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseMathFunctions;

namespace Exercise_1A_Mathematic_formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Basic Difficulty Questions
            // Determining Area, Circumference, and Volume from a given radius.
            Console.WriteLine("Please enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * (radius * radius);
            double circ = 2 * Math.PI * radius;
            double volume = 4.0 / 3 * Math.PI * (radius * radius * radius) / 2;
            Console.WriteLine("The area is: {0:F2} ", area);
            Console.WriteLine("The circumference is: {0:F2} ", circ);
            Console.WriteLine("The volume is: {0:F2} ", volume);
            Console.ReadLine();
            Console.Clear();

            // Intermediate Difficulty Question
            // Area of a triangle given the length of sides
            // FL = First Length   SL = Second Length   TL = Third Length   P = Half of the Circumference   A = Area
            Console.WriteLine("Please enter the first length: ");
            double FL = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second length: ");
            double SL = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third length: ");
            double TL = double.Parse(Console.ReadLine());
            double P = (FL + SL + TL) / 2;
            double A = Math.Sqrt(P * (P - FL) * (P - SL) * (P - TL));
            Console.WriteLine("The area of the triangle is: {0:F2} ", A);

            // Advanced Difficulty Question
            //Solving a quadratic equation


        }
    }
}
