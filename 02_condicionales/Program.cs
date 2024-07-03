 //Simple conditional
Console.WriteLine("Please enter your age: ");

byte age = Convert.ToByte(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine($"You're {age} years old, so you're an adult");
}
else
{
    Console.WriteLine($"You're {age} years old, so you're a minor");
}

//----------------------------------------------------------------

//Complete conditional

if (age <= 15)
{
    Console.WriteLine("Shut up kid, go back to kindergarden");
}
else if (age >= 15 && age < 18)
{
    Console.WriteLine("You're still a kid, don't pretend to be old");
}
else if (age >= 18)
{
    Console.WriteLine("You're an adult now");
}

//----------------------------------------------------------------
//Switch case

Console.WriteLine("Please enter a number between 1 and 7: ");
byte numeric = Convert.ToByte(Console.ReadLine());

switch (numeric)
{
    case 1:
    Console.Write("You chose Monday!");
    break;
    case 2:
    Console.Write("You chose Tuesday!");
    break;
    case 3:
    Console.Write("You chose Wednesday!");
    break;
    case 4:
    Console.Write("You chose Thursday!");
    break;
    case 5:
    Console.Write("You chose Friday!");
    break;
    case 6:
    Console.Write("You chose Saturday!");
    break;
    case 7:
    Console.Write("You chose Sunday!");
    break;
} 