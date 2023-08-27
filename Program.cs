System.Console.WriteLine("Enter this year!");
string thisYear = Console.ReadLine();

System.Console.WriteLine("Enter year of birth!");
string OwnYear = Console.ReadLine();

int x = Convert.ToInt32(OwnYear);
int Year = Convert.ToInt32(thisYear);

int dayofbirth = Year - x;

System.Console.WriteLine($"Your birth day is {dayofbirth * 365}");