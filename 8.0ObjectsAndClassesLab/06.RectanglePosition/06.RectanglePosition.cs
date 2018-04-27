using System;
using System.Linq;

namespace _06.RectanglePosition
{
    class Program
    {
        static void Main()
        {
            Rectangle firstRectangle = ReadRectangle();
            Rectangle secondRectangle = ReadRectangle();

            bool result = firstRectangle.InsideRectangle(secondRectangle);
            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
        public static Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return new Rectangle()

            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            }   ;
        }
    } 
}

class Rectangle
{
    //Data properties 
    public int Top { get; set; } //Class fields
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    // Classes may hold methods(operations).
    //Method which will calculate the total area.
    int CalculateArea()
    {
        return Width * Height;
    }

    //Calculated property
    public int Bottom { get { return Top + Height; } } //Class properties 

    public int Right { get { return Left + Width; } }

    public bool InsideRectangle(Rectangle r)
    {
        // return (r.Left <= r.Left) && (r.Right >= r.Right) && (r.Top <= r.Top) && (r.Bottom >= r.Bottom);
        bool leftIsValid = r.Left <= Left;

        bool topIsValid = r.Top <= Top;

        bool rightIsValid = r.Right >= Right;

        bool bottomIsValid = r.Bottom >= Bottom;

        return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
    }

   }

