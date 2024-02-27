// See https://aka.ms/new-console-template for more information


//Rakendus küsib kasutajal sisetada tema vanuse
//kui vanus alla 16 siis kuvatakse:
//"You are too young to use Instagram"
//muul juhul konsoolis kuvatakse "Welcome to instagram"

using System.Threading.Channels;

Console.WriteLine(  "Enter your age");

//int userAge = Int32.Parse(Console.ReadLine());//"13"-heap. 13-stack

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
if (isAgeNumber)
{

    if (userAgeNum >= 13)
    {
        Console.WriteLine("welcome to Instagram!");
    }

    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }
}
else

{

    Console.WriteLine("Could not read your age.");

}