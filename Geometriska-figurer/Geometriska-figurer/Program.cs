using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ViewMenu();
                int userSelection;
                string choice = Console.ReadLine();
                try
                {
                    userSelection = int.Parse(choice);
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
                        //ShapeType ellipse = ShapeType.Ellipse;
                        ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                       
                        //starta ellipse
                        break;
                    case 2:
                        //ShapeType rectangle = ShapeType.Rectangle;
                        ViewShapeDetail(CreateShape(ShapeType.Rectangle));
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
            Shape myShape = null;
            Console.ResetColor();
            double length = ReadDoubleGreaterThanZero(string.Format("Ange längden på din {0}:", shapeType));
            double width = ReadDoubleGreaterThanZero(string.Format("Ange bredden på din {0}:", shapeType));
            if (shapeType == ShapeType.Rectangle)
            {
                myShape = new Rectangle(length, width);
            }
            if (shapeType == ShapeType.Ellipse)
            {
                myShape = new Ellipse(length, width);
            }
            return myShape;
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
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=               Detaljer               =");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());//tostring
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
                    if (number <= 0)
                    { Console.WriteLine("FEL! Ange ett tal större än 0!"); }
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
