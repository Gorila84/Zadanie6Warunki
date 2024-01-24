//poseł 21
//senator 30
//prezydent 35

int height;


Console.WriteLine("Wprowadź swój wzrost: ");
var enteredHeight = Console.ReadLine();

Int32.TryParse(enteredHeight, out height);

if (height <= 140)
{
    Console.WriteLine("Nie wpuszczą Cię do makro. Jesteś za niski.");
}
else if (height > 140 && height <= 165)
{
    Console.WriteLine("Możesz wejśc do makro ale nie dostaniesz do górnych półek.");
}
else if (height > 165 && height <= 180)
{
    Console.WriteLine("Jesteś przeciętnego wzrostu.");
}
else
{
    Console.WriteLine("Idź grać w kosza");
}