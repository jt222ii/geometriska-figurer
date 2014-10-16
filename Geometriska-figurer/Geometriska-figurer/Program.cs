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
                Console.Clear();
                ViewMenu(); // skriver ut menyn
                int userSelection;
                string choice = Console.ReadLine(); // användaren skriver in något av valen 0-2. Kollar sedan genom en try-catch så att det är ett giltigt heltal 

                try
                {
                    userSelection = int.Parse(choice); //gör om strängen choice till int - funkar inte det kastas ett undantag.
                    switch (userSelection) //userselection är det som användaren gav ett värde ovan. 
                    {
                        case 0: //avslutar programmet
                            return;
                        case 1://Om användaren valde alternativ 1 anropas metoden ViewShapeDetail där värdena från CreateShape där man skickar med ShapeType.Ellipse skickas med.
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse)); //CreateShape körs före ViewShapeDetails.
                            break;
                        case 2://Om användaren valde alternativ 2 anropas metoden ViewShapeDetail där värdena från CreateShape där man skickar med ShapeType.Rectangle skickas med.           
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));   //CreateShape körs före ViewShapeDetails.
                            break;
                        default: //körs om det inte är något av de ovanstående
                            Console.WriteLine("var snäll och ange ett av valen 0-2!");
                            break;
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! '{0}' är inte i rätt format. Ange en siffra större än noll!", choice);
                    Console.ResetColor();      //undantag kastas
                }
                

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nTryck valfri tangent för ny uträkning - ESC avslutar ");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

           // CreateShape();

            //ViewDetail();

        }
        private static Shape CreateShape(ShapeType shapeType) // Tar emot argument som bestämer vilken figur som ska skapas. "Målar" ut namnet på den geometriska figur man har valt med hjälp av en switch sats och låter sedan användaren skriva in längden och bredden.
        {
            switch(shapeType)
            {
            case ShapeType.Ellipse:  //om användaren valde Ellipse så har shapeType värdet ShapeType.Ellipse. Detta är ett lättare sätt att förstå koden än om switchen använde sig av 0,1,2,3 etc då man ser vad det är den kollar.
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=                Ellipse               =");
            Console.WriteLine("========================================");
            break;

            case ShapeType.Rectangle: //samma som ovan fast för Rectangle
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=               Rectangle              =");
            Console.WriteLine("========================================");
            break;
            }
            Console.ResetColor();
            double length = ReadDoubleGreaterThanZero(string.Format("Ange längden på din {0}:", shapeType));
            double width = ReadDoubleGreaterThanZero(string.Format("Ange bredden på din {0}:", shapeType));

            
            if (shapeType == ShapeType.Rectangle)
            {
                return new Rectangle(length, width);  //skickar med längd och bredd till konstruktorn för vald figur
            }
            if (shapeType == ShapeType.Ellipse)
            {
                return new Ellipse(length, width); //skickar med längd och bredd till konstruktorn för vald figur
            }
            return null;
        }
        private static void ViewMenu() //skriver ut menyn
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
        private static void ViewShapeDetail(Shape shape)//skriver ut resultaten.
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=               Detaljer               =");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());//anropar och skriver ut det som ToString() returnerar.
            Console.WriteLine("========================================");
        }
        private static double ReadDoubleGreaterThanZero(string prompt)//Denna metoden returnerar det värde som användaren skriver in så länge man skriver in ett tal som är större än 0.
        {
            double number;
            while (true)
            {
                Console.WriteLine(prompt); //prompten skriver ut den sträng som skickades med när metoden anropades
                string userInput = Console.ReadLine(); //användaren skriver in ett värde
                try
                {
                    number = double.Parse(userInput); // försöker göra om strängen userInput till en double. Funkar inte det kasstas ett undantag
                    if (number <= 0)//kollar så att numret man skrev in inte är mindre eller lika med 0
                    { Console.WriteLine("FEL! Ange ett tal större än 0!"); }
                    else
                    { return number; }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! '{0}' är inte i rätt format. Ange en siffra större än noll!", userInput);
                    Console.ResetColor();
                }
            }
        }

    }
}
