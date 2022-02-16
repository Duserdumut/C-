

//variable holding users choise
int x = 0;


//Welcome message
Console.WriteLine("Välkommen till Daniels bilhandel");
Console.WriteLine("********************************");
Console.ReadKey();

while (true)
{
    //Cleaining up the menu
    Console.Clear();

  

    //MainMenu options
    Console.Clear();
    Console.WriteLine("Välj något av nedanstående valen: ");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("1. Sälja din bil");
    Console.WriteLine("2. Köpa en bil");
    Console.WriteLine("3. Tvätta din bil");
    Console.WriteLine("4. Avsluta programet");


    //Getting users choice in menu
    Console.WriteLine("Skriv in ditt val");
    string answer = Console.ReadLine();
    if (int.TryParse(answer, out x)) {
       
        /*
         x = Convert.ToInt32(Console.ReadLine());
        */
        

        //Condition to get function of choice
        if (x == 1)
        {
            Console.Clear();
            Console.WriteLine("Du valde att sälja din bil");
            Console.WriteLine("Tryck Enter för att gå tillbaka till menyn");
            Console.ReadKey();
        }
        else if (x == 2)
        {
            Console.Clear();
            Console.WriteLine("Du valde att köpa en ny bil");
            Console.WriteLine("Tryck Enter för att gå tillbaka till menyn");
            Console.ReadKey();
        }

        else if (x == 3)
        {
            Console.Clear();
            Console.WriteLine("Du valde att tvätta din bil din bil");
            Console.WriteLine("Tryck Enter för att gå tillbaka till menyn");
            Console.ReadKey();
        }


        //To exit the program
        else if (x == 4)
        {
            Console.Clear();
            Console.WriteLine("Du har valt att avsluta programmet");
            Console.WriteLine("Tryck Enter för att avsluta programmet");
            Console.ReadKey();
            break;
        }

        //If the user press a number outside menuchoices

        else
        {
            Console.Clear();
            Console.WriteLine("Du har gjort ett ogiltigt val! \n Gå tillbaka till menyn och gör ett nytt val");
            Console.WriteLine("tryck på enter för att återgå till menyn.");
            Console.ReadKey();
        }

    }

   


}

