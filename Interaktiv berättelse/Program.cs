using System.Xml.Serialization;

string choice = "";

Console.WriteLine("Du vaknar upp och du befinner dig i en kvinnas säng och hon ligger bredvid dig.");
Console.WriteLine("Du har helt glömt bort vart du är och vem kvinnan är");
Console.WriteLine("Du väljer mellan att investigera kvinnan eller rummet.");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "kvinnan")
{
    Console.WriteLine("Du drar bort täcket och du ser att det inte är en kvinna du tittar på utan det är en man");
    Console.WriteLine("Resultatet blev att du hittade att det var en man som låg bredvid dig men du orsakade också en hel del ljud så nu är mannen vaken.");
    Console.WriteLine("Mannen blir lite upprörd och aggresiv så han går till attack och slår sönder dig.");

}

else if (choice == "rummet")
{
    Console.WriteLine("Du investigerar rummet och ser att fönstrerna har galler och dörren är låst.");
    Console.WriteLine("Du bestämmer dig för att leta efter nyckeln till dörren.");
    Console.WriteLine("Letar du under sängen eller i kvinnans väska?");
}

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "sängen")
{
    Console.WriteLine("");


}