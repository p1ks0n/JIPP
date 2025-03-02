using System;

class Program
{
	static void Main()
	{
		// Zadanie 2
		Console.WriteLine("Podaj swoje imię:");
		var name = Console.ReadLine();
		Console.WriteLine("Hello " + name);

		// Zadanie 3 - poprawiony błąd (brak średnika)
		int result = 5 + 9;
		Console.WriteLine("Wynik: " + result);

		// Operatory - Zadanie 1
		int number = 10;
		float money = 20.5f;
		string text = "Przykładowy tekst";
		bool isLogged = true;
		char myChar = 'A';
		decimal price = 99.99m;

		Console.WriteLine($"Number: {number}, Money: {money}, Text: {text}, Logged: {isLogged}, Char: {myChar}, Price: {price}");

		// Operatory - Zadanie 2
		string myAge = "Age: ";
		int wifeAge = 18;
		string result2 = myAge + wifeAge; // Konwersja int na string podczas konkatenacji
		Console.WriteLine(result2);
		// Wniosek: Konkatenacja stringa i int automatycznie konwertuje int na string.

		// Operatory - Zadanie 3
		bool isTrue = true;
		bool isFalse = false;
		bool isReallyTrue = true;

		bool and = isTrue && isFalse;
		bool or = isTrue || isReallyTrue;
		bool negative = !isFalse;

		Console.WriteLine($"AND: {and}, OR: {or}, NEGATION: {negative}");

		// Operatory - Zadanie 4
		int a = 5, b = 12;
		int add = a + b;
		int sub = a - b;
		int div = b / a;
		int mul = a * b;
		int mod = b % a;

		Console.WriteLine($"Add: {add}, Sub: {sub}, Div: {div}, Mul: {mul}, Mod: {mod}");

		// Operatory - Zadanie 5
		string strA = "Ala ";
		string strB = "ma ";
		string strC = "kota.";
		string resultStr = strA + strB + strC;
		Console.WriteLine(resultStr);
		// Wniosek: Operacja + na stringach łączy je w jeden ciąg znaków.
	}
}
