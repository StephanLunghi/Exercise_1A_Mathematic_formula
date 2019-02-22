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
            try
            {

            
            
                // Basic Difficulty Questions
                // Determining Area, Circumference, and Volume from a given radius.
                Console.WriteLine("Please enter a radius to determine the area and circumference of a circle. As well as the volume of a hemisphere: ");
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
                // Looked up how to space out writelines. Is there a better way? Looks messy in my opinion.
                Console.WriteLine(@"Enter the length of the sides of a triangle to determine the area.  
Please enter the first length: ");
                double FL = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second length: ");
                double SL = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the third length: ");
                double TL = double.Parse(Console.ReadLine());
                double P = (FL + SL + TL) / 2;
                double A = Math.Sqrt(P * (P - FL) * (P - SL) * (P - TL));
                Console.WriteLine("The area of the triangle is: {0:F2} ", A);
                Console.ReadLine();
                Console.Clear();

                // Advanced Difficulty Question
                // Solving a quadratic equation
                // I had a hard time understanding how to code this, I used Stackoverflow and Youtube videos to help with this. I ended up using the same simple style as the other equations.

                Console.WriteLine(@"Input a values to solve a quadratic equation. 
Input a value for A");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Input a value for B");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Input a value for C");
                double c = double.Parse(Console.ReadLine());

                double Root = Math.Sqrt(b * b - 4 * a * c);
                if (Root >= 0)
                {
                    double x1 = (-b + Root) / 2 * a;
                    double x2 = (-b - Root) / 2 * a;
                    Console.WriteLine("x1= " + x1 + " x2= " + x2);
                }
                else
                {
                    Console.WriteLine("Sorry, there is no root");
                }
                // Attempting a "try-catch" because these errors hurt my head

            }
            catch
            {
                Console.WriteLine("Sorry, this input was not a number");
            }
            finally
            {
                Console.WriteLine();
                Console.ReadLine();
            }

        }
    }
}
