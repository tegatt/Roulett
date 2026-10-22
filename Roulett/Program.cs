Console.WriteLine("How much do u want to bet?");
string input = Console.ReadLine();

Console.WriteLine("Chose number to bet on");
Console.WriteLine("[1]\n[2]");
string input2 = Console.ReadLine();


Random rand = new Random();
int number = rand.Next(1, 2);

Console.WriteLine(number);





