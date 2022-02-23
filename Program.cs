using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag2csharp
{



    class Mainclass
    {
        static void Main(string[] args)
        {



            #region variables
            CarList carList = new CarList();
            var car1 = new Car("Volvo", "Xc60", 2018, 12430, 250000);
            var car2 = new Car("Nissan", "Qashqai", 2009, 19583, 80000);
            var car3 = new Car("VolksWagen", "Poolo", 2005, 24003, 30000);
            var car4 = new Car("BMW", "Z4", 2014, 4500, 140000);
            

            carList.cars.Add(car1);
            carList.cars.Add(car2);
            carList.cars.Add(car3);
            carList.cars.Add(car4);
            #endregion

            //Welcome Message
            Console.WriteLine("Hej och välkommen till Daniels Bilmek! \n**************************************\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Här är lite olika alternativ för dig att välja mellan\n\n1. Vill du köpa en bil\n2. Vill du sälja din bil?\n3. Vill du Serva din bil?\n4. Vill du avsluta programmet?\n\nVälj ett av ovanstående alternativen");

                //Menu options
                string x;
                do
                {
                    x = Console.ReadLine();
                    if (x == "1")
                    {
                        BuyingCarMenu(carList);
                    }
                    else if (x == "2")
                    {
                        SellingCarMenu();
                    }
                    else if (x == "3")
                    {
                    ServingCarMenu();
                    }
                    else if (x == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Tryck på Enter för att stänga av programmet");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("Du har gjort ett ogiltigt val! \nVälj ett av valen ovanför");
                        Console.ReadKey();
                    }
                } while (true);
        }
        
        // Car menu to pick from
        public static void BuyingCarMenu(CarList carList)
        {
            Console.Clear();
            Console.WriteLine($"Vad roligt! Detta är vårat sortement av bilar: \n");

            for (int i = 0; i < carList.cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {carList.cars[i].Name} {carList.cars[i].Model} från {carList.cars[i].Vintage}. Den har gått {carList.cars[i].Mileage} och kostar {carList.cars[i].Price}.");  
            }
            Console.WriteLine("\nGör ett val för att gå vidare");

            //Picking a car and message for buying it
            string y;
            do
            {
                y = Console.ReadLine();
                if (y == "1")
                 {
                    Console.Clear();
                    Console.WriteLine($"Så du valde att köpa Volvon!\nVad roligt att göra affärer med dig!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                 }
                else if (y == "2")
                {
                    Console.Clear();
                    Console.WriteLine($"Så du valde att köpa Nissan!\nVad roligt att göra affärer med dig!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                }
                else if (y == "3")
                {
                    Console.Clear();
                    Console.WriteLine($"Så du valde att köpa VolksWagen!\nVad roligt att göra affärer med dig!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                }
                else if (y == "4")
                {
                    Console.Clear();
                    Console.WriteLine($"Så du valde att köpa BMWn!\nVad roligt att göra affärer med dig!\nTryck på Enter för att avsluta programmet");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Du har gjort ett ogiltigt val!\nVälj en av de fyra bilarna");
                }

            } while (true);
        }

        //Getting the info from buyer about his carand name. We are buying it too here
        public static void SellingCarMenu()
        {
            Console.Clear();
            Console.WriteLine("För att sälja din bil behöver jag ditt namn:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Så {name} du vill sälja din bil alltså.\nVad trevligt, för att köpa din bil kommer jag att behöva vet lite mer om den.");
            Console.WriteLine("Skriv in vilken märke och model det är:");
            string model = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Jasså en {model} låter inte helt dumt.\nJag behöver även veta hur många mil den har gått.\nSkriv in hur många mil den har gått:");
            int mileage = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"så {name} du vill sälja din {model} som har gått {mileage}mil.\nHur mycket vill du sälja den för? ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"{price}kr Jag kan tänka mig det priset faktiskt\nTack för en bra affär ha en trevlig dag.");
            Console.ReadKey();
        }
        //Options from the service menu
        public static void ServingCarMenu()
        {
            Console.Clear();
            Console.WriteLine("Bil service, detta är vad du kan välja mellan:\n\n1. Oljebyte\n2. Däckbyte");
            string x;
            do
            {
               
                x = Console.ReadLine();
                if (x == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Vad bra att du bytade olja hos oss!\nTack för besöket ");
                    Console.ReadKey();
                }
                else if (x == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Vad bra att du bytade däck hos oss!\nTack för besöket");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Du har gjort ett ogiltigt val! \nVälj ett av valen ovanför");
                    Console.ReadKey();
                }
            } while (true);



        }

    }
    



}
