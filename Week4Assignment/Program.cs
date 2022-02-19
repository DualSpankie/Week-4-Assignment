using System;

namespace Week4Assignment
{
    class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            random = new Random();

            MakeRectangle(out int n1, out int n2);

            Rectangle w = new Rectangle();

            Console.WriteLine("Length: " + n1); //Display random number one.

            Rectangle h = new Rectangle();

            Console.WriteLine("Width: " + n2); //Display random number two.

            Rectangle a = new Rectangle();

            Console.WriteLine("Area: " + n1 * n2); //Displays calculated perimeter with two random numbers.

            Rectangle p = new Rectangle();

            Console.WriteLine("Perimeter: " + (2 * (n1 + n2)));  //Displays calculated perimeter with two random numbers.
        }
        class Rectangle
        {   
            public int height; //Declaring value of height
            public int width; //Declaring value of width

            public Rectangle() //Constructor for rectangle. 
            {

            }
        }
        class mathUtility
        {

        }
        public static int Area(int width, int height)
        {
            return width * height; //Area = width * height
        }
        public static int Perimeter(int width, int height)
        {
            return 2 * (width + height); //Perimeter = 2 (width + height)
        }
        public static void MakeRectangle(out int n1, out int n2)
        {
            n1 = random.Next(1, 100); //Sets a random number from 1 to 100 for number one.
            n2 = random.Next(1, 100); //Sets a random number from 1 to 100 for number two.
        }
    }
}