// See https://aka.ms/new-console-template for more information


//Rakendus palub kasutajal valida tema sugi (m/f)
// Rakendu palub kasutajal sisestada tema perekonna nime
//Lähtudes kasutaja valikust rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [perenimi] või Ms. ....

Console.WriteLine("Please select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());//loeb konsoolist sõnena/stringina

Console.WriteLine("Pleass enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome Mr.{userLastName}!");
}
else if (userGender == 'f'){
    Console.WriteLine($"Welcome Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}");
}
