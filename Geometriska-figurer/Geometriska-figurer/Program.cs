using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    class Program
    {
        public enum ShapeType {Rectangle, Ellipse};
        static void Main(string[] args)
        {
            do
            {
                ViewMenu();
                int userSelection;
                ConsoleKeyInfo choice = Console.ReadKey();
                try
                {
                    userSelection = int.Parse(choice.ToString());
                }
                catch
                {
                    throw new ArgumentException();
                }
                switch (userSelection)
                {
                    case 0:
                        return;
                    case 1:
                        //ViewShapeDetail(CreateShape(ShapeType.Ellipse);
                        //starta ellipse
                        break;
                    case 2:
                        //starta rectangle
                        break;
                    default:
                        Console.WriteLine("var snäll och ange ett av valen 0-2!");
                        break;
                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nTryck valfri tangent för ny uträkning - ESC avslutar ");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

           // CreateShape();

            //ViewDetail();


        }
        private static Shape CreateShape(ShapeType shapeType)
        {
            switch(shapeType)
            {
            case ShapeType.Ellipse:
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=                Ellipse               =");
            Console.WriteLine("========================================");
            break;

            case ShapeType.Rectangle:
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=               Rectangle              =");
            Console.WriteLine("========================================");
            break;

            }
            Console.ResetColor();
            throw new ArgumentException();
            //enum shapetype wat my schnegel?
        }
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=          Geometriska Figurer         =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine("\n 0. Avsluta.\n 1. Ellips\n 2. Rektangel.");
            Console.WriteLine("========================================");
        }
        private static void ViewShapeDetail(ShapeType shapeType)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=               Detaljer               =");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine();//tostring
            Console.WriteLine("========================================");
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double number;
            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                try
                {
                    number = double.Parse(userInput);
                    if (number < 0)
                    { Console.WriteLine("FEL! Ange ett tal högre än 0!"); }
                    else
                    { return number; }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! {0} är inte i rätt format. Ange en siffra större än noll!");
                    Console.ResetColor();
                }
            }
        }

    }
}
