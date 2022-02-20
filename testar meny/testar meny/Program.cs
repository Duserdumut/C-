

Mainmenu();




// menu options
static void Mainmenu()
{
    Console.WriteLine("Välkommen till min affär ");
    Console.WriteLine(" ");
    Console.WriteLine("1. Sälja din bil");
    Console.WriteLine("2. Köpa en bil");
    Console.WriteLine("3. Tvätta din bil");
    Console.WriteLine("4. Avsluta programmet ");
    Console.WriteLine("Skriv in en siffra av de ovanstående valen");
    
    //how the computer pick an option
    string myoptions;
    myoptions = Console.ReadLine();
     switch (myoptions)
     {
        case "1":
            Sälja();
            break;

        case "2":
            Köpa();
            break;

        case "3":
            Tvätta();
            break;

        case "4":
            Avsluta();
            break;
      }
   
    //diffrent menu options
    static void Välkommen()
    {
        Console.WriteLine("Välkommen till Daniels Bilhandel!");
        Console.WriteLine("*********************************");
        Console.ReadKey();
    }
    // Option wanna sell his care
    static void Sälja()
    {

        Console.Clear();
        Console.WriteLine("Du gjorde valet: Sälja din bil");
        Console.WriteLine("För att fortsätta här kommer jag behöva ditt för och efternamn");

        //Asking for name

        string Namn = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Okej {Namn} jag behöver även ditt personnummer, inte de 4 sista siffrorna");
        Console.ReadKey();

        //Asking for personal number

        int Personnummer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Så {Namn} och {Personnummer}, Stämmer det ? ");
        Console.WriteLine("1. Ja det stämmer ");
        Console.WriteLine("2. Nej det stämmer inte");
        Console.WriteLine("3. Tryck här för att komma till huvud menyn");
        Console.ReadKey();
        //If the user wanna continue with selling his car
        //
        string optionsell;
        optionsell = Console.ReadLine();
        switch (optionsell)
        {
            case "1":
                Console.WriteLine("coolt");
                break;
        }

    }

    static void Köpa()
    {
        Console.WriteLine("coolt fan");

    }
    static void Tvätta()
    {


    }
    static void Avsluta()
    {

    }
}
