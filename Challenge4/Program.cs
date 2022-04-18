/*
This challenge build a program that will be a little like mad-libs in nameing something
Also shows how to concactinate strings and variables into one output.
*/

// Ask the user what they arewanting to name
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();

/* Get adjectives from the user
   give a few options, but the
   user can input any          */
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();

// Everything is "Of Doom"!
string c = "of Doom";
string d = "3000";

// Write it all out
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");