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
            // Determining Area and Circumference from a given radius.
            Console.WriteLine("Please enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * (radius * radius);
            double circ = 2 * Math.PI * radius;
            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The circumference is: " + circ);
            Console.ReadLine();
            Console.Clear();

            // Intermediate Difficulty Question
            // Determining volume from a given radius length
            // RL = Radius Length
            Console.WriteLine("Please enter the radius length: ");
            double RL = double.Parse(Console.ReadLine());
            

        }
    }
}
