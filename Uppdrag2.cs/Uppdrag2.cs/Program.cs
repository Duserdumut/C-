// välkommen/start
Console.WriteLine("Tryck på Enter för att starta");
Console.ReadLine();
Console.WriteLine("Hejsan och välkommen till min bilaffär.");
Console.ReadLine();

// första valen i menyn
int x = 1;

Console.WriteLine("Du kommer nu att få olika val.");
Console.WriteLine("Välj (1) för att tvätta bilen");
Console.WriteLine("Välj (2) för att fortsätta vidare i menyn");
x = Convert.ToInt32(Console.ReadLine());



// svar för tvätta bilen eller fortsätta 
switch (x)
{
    case 1:
        Console.WriteLine("Val (1) att tvätta bilen");
        break;
    case 2:
        Console.WriteLine("val (2)Fortsätta med menyn");
        break;
    default:
        Console.WriteLine("inget av de ovanstående valet stämmer");
        break;
}
//tvättade sin bil
if (x == 1)
{
    Console.WriteLine("Så du är här för tvätta din bil. Trevligt, bara att ställa den på parkeringen. Vi tvättar den så snart vi kan");
    Console.WriteLine("tryck vilken knapp du vill för att stänga av programmet");
    Console.ReadLine();
    Environment.Exit(0);
}
//vill vidare i menyn, nya alternativ
else if (x == 2) { 

    Console.WriteLine("Välj (1) För att sälja en bil");
    Console.WriteLine("Välj (2) för att fortsätta vidare i menyn");
    x = Convert.ToInt32(Console.ReadLine());
    
}



//svar för att sälja bilen eller fortsätta
switch (x)
{
    case 1:
        Console.WriteLine("val (1) Sälja Bilen");
        break;
    case 2:
        Console.WriteLine("val (2) Fortsätta med menyn");
        break;
    default:
        Console.WriteLine("inget av de ovanstående valet stämmer");
        break;
}
//sålde bilen
if (x == 1)
{
    Console.WriteLine("Så du är här för att sälja din bil, trevligt. ");
    Console.WriteLine("tryck vilken knapp du vill för att stänga av programmet");
    Console.ReadLine();
    Environment.Exit(0);
}
//vill vidare i menyn, nya alternativ
else if (x == 2) {
    Console.WriteLine("Välj (1) Köpa en bil");
    Console.WriteLine("Välj (2) för att fortsätta vidare i menyn");
    x = Convert.ToInt32(Console.ReadLine());
}



//svar för att köpa bilen eller fortsätta
switch (x)
{
    case 1:
        Console.WriteLine("val (1) Köpa en bil Bilen");
        break;
    case 2:
        Console.WriteLine("val (2) slut på alternativ.");
        break;
    default:
        Console.WriteLine("inget av de ovanstående valet stämmer");
        break;
}
//köpte ny bil
if (x == 1)
{
    Console.WriteLine("Så du är här för att köpa en ny bil, roligt. Här har vi massor. ");
    Console.WriteLine("tryck vilken knapp du vill för att stänga av programmet");
    Console.ReadLine();
    Environment.Exit(0);
}
// svar för att fortsätta i menyn/ avslutas här
else if (x == 2)
{

    Console.WriteLine("Hejsan det är tyvärr inga fler alternativ för tillfället.");
    Console.WriteLine("tryck vilken knapp du vill för att stänga av programmet");
    Console.ReadLine();
    Environment.Exit(0);
}
