﻿using System;

namespace MulticastingDelegate
{
    class Rectangle
    {
        // declaring delegate
        public delegate void rectDelegate(double height, double width);
        
        // "area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }
        
        // "perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeteris: {0}", 2 * (width + height));
        }    
        
        // Main method
        public static void Main(String[] args)
        {
            // creating object of class "rectangle", named "rect"
            Rectangle rect = new Rectangle();

            // creating delegate object, name as "rectangle" and pass the parameter by the class object "rect"
            rectDelegate rectdele = new rectDelegate(rect.area);
            //also can be written as rectDelegate rectdele = rect.area;

            //call 2nd method "perimeter" Multicasting
            rectdele += rect.perimeter;
            
            //pass the values in two method by using "Invoke" method
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            //call the methods with different values
            rectdele.Invoke(16.3, 10.3);
        }
    }
}
