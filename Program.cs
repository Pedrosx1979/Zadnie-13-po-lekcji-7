
using System;

Console.WriteLine("Prosty kalkulator :)");

Console.WriteLine("Wprowadź pierwszą liczbę: ");
double a = Double.Parse(Console.ReadLine());
//int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Wprowadź drugą liczbę: ");
double b = Double.Parse(Console.ReadLine());
//int b = Int32.Parse(Console.ReadLine());



Console.WriteLine("Wybierz operację matematyczną \n 1. Dodawanie.\n 2. Odejmowanie. \n 3. Dzielenie. \n 4. Mnożenie.");
int operation = Int32.Parse(Console.ReadLine());
switch (operation)
{
    case 1:
        Console.WriteLine($"Wynik dodawania to: {a + b}");
        break;
    case 2:
        Console.WriteLine($"Wynik odejmowania t0: {a - b}");
        break;
    case 3:                    // zagnieżdzenie instrukcji if 
        if (a == 0 || b == 0) // dzielenie przez zero przykład kodu
        {
            Console.WriteLine("NIE DZIELIMY PRZEZ 0!!!");
        }
        else
        {
            Console.WriteLine($"Wynik dzielenia t: {a / b}");
        }
        break;
    case 4:
        Console.WriteLine($"Wynik mnożenia t: {a * b}");
        break;
    case 5:
        if (a != 0 && a != 1 && a != 2 && a != 3 && a != 4 && a != 5 && a != 6 && a != 7 &&
           a != 8 && a != 9 && a != 0
           || b != 1 && b != 2 && b != 3 && b != 4 && b != 5 && b != 6 && b != 7 &&
           b != 8 && b != 9 && b != 0)
        {
            Console.WriteLine("Nacisnąłęś zły klawiasz");
        }
        return;
        break;




};