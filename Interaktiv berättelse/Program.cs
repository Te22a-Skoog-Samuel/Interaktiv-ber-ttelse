Console.WriteLine("Skriv in ditt namn");
string name = Console.ReadLine().ToLower();

if (name == "skoogen" || name == "samuel")
{
    Console.WriteLine("Välkommen");


}
else if (name == "alex")
{
    Console.WriteLine("Sveriges stolthet");
}

else
{
    Console.WriteLine("Du är inte välkommen hit");
}

Console.ReadLine();