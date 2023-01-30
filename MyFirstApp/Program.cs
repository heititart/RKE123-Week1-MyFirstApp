// This is a comment to my code


//Rakendus küsib kasutajalt nime
// Seejärel tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");// output
// String - sõne
string userName = Console.ReadLine();//input

Console.WriteLine("Hello" +", "+ userName + "!");//output
//string interpolation

Console.WriteLine($"Hello, {userName}! ");//input

Console.WriteLine("Sisesta perekonna nimi:");
string familyName = Console.ReadLine();
Console.WriteLine($" Tere {userName} {familyName}");

