﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hej! Vad är ditt förnamn??");
string förnamn= Console.ReadLine();
Console.WriteLine("coolt namn du har " + förnamn +"! Men vad är ditt efternamn??");
string efternamn= Console.ReadLine();
Console.WriteLine("det blev ju ännu coolare! så du heter " + förnamn + efternamn + " :)");
System.Console.WriteLine("Testa mig med lite matte! Ge mig ett heltal.");
string Number1= Console.ReadLine();
int tal1 = int.Parse(Number1);
 Console.WriteLine("coolt! Ett till tack.");
 string number2= Console.ReadLine();
int tal2 = int.Parse(number2);
 Console.WriteLine("kalkulerar...");
Console.WriteLine("Summa: " + (tal1 + tal2));