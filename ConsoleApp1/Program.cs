// See https://aka.ms/new-console-template for more information
﻿int points = 0;

Console.WriteLine("Välkommen till Georgios Tv-Spel-frågesport!");



Console.WriteLine("1: Vilket spel har dem flesta GOTY ?");
Console.WriteLine("a) The Last of Us Part II  b) God of War c) The Witcher 3");
string answer1 = Console.ReadLine();
if (answer1 == "a")
{
  points++;
  Console.WriteLine("Correct");
}
else
{
  Console.WriteLine("Incorrect");
}



Console.WriteLine("2: Vilket indiespel har vunnit flest priser och erkännande de senaste åren?");
Console.WriteLine("a) Celeste b) Hades c) Disco Elysium");
string answer2 = Console.ReadLine();
if (answer2 == "b")
{
  points++;
  Console.WriteLine("Correct");
}
else
{
  Console.WriteLine("Incorrect");
}



Console.WriteLine("3: Vilka spel har vunnit utmärkelser för bästa VR-upplevelse??");
Console.WriteLine("a): Boneworks b) Beat Saber  c) Half-Life Alyx");
string answer3 = Console.ReadLine();
if (answer3 == "c")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}



Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du har verkligen ingen aning.");
}
else if (points < 3)
{
  Console.WriteLine(" Du har ganska bra koll – eller gissade rätt på några par gånger.");
}
else 
{
  Console.WriteLine("Grattis! Du fick rätt på allting!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();