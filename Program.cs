Console.WriteLine("Enter your name: ");
string name = Console.ReadLine()!;
string greeting = $"(Hello {name})";
Console.WriteLine(greeting);
Console.WriteLine("Enter your age: ");
string ageAsString = Console.ReadLine()!;
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Succesfully converted! {age}");
int keschasAge = 3;
int ageDiference = age -keschasAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDiference}"); 
if(age>keschasAge)
{
    System.Console.WriteLine("Siz keschadan u'lkensiz.");
}
else if( age==keschasAge )
{
    System.Console.WriteLine("Sizdin' jasin'iz kescha menen ten'");
}
else
{
    System.Console.WriteLine("Siz keschadan kishisiz");
}
