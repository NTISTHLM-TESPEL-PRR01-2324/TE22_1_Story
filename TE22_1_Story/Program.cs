
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine().ToLower();

// Kolla om namnet är "micke"
if (name == "micke" || name == "Micke")
{
  Console.WriteLine("Välkommen!");
}
else if (name == "martin")
{
  Console.WriteLine("Lite välkommen!");
}
else
{
  Console.WriteLine("Inte välkommen!");
}

// if (name != "micke")
// {
//   Console.WriteLine("Fuck off!");
// }

Console.ReadLine();