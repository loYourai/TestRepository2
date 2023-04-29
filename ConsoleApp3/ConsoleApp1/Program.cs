// See https://aka.ms/new-console-template for more information
//int first = 10;
//int second = 5;
//int third = first + second;

//Console.WriteLine(10 / 2);
//Console.WriteLine(11 / 2);
//Console.WriteLine(12 / 2);
//Console.WriteLine(13 / 2);

// floating types operations
//double a = 6.2;
//float b = 6.2F;
//decimal c = 6.2M;

//Console.WriteLine(a / 3);
//Console.WriteLine(b / 3);
//Console.WriteLine(c / 3);

// multiplications
//int first = 11;
//int second = 2;

//Console.WriteLine(first / second);
//Console.WriteLine(first % second);

// increment
//int first = 1;

//Console.WriteLine(++first);
//Console.WriteLine(first);

// comparison

//int first = 12;
//int second = 13;
//bool result = first >= second;
//bool secondResult = first < second;

//Console.WriteLine(first != second); // true == false ==> false

// size types

//int a = 10;
//int b = int.MaxValue;
//long l = long.MaxValue;
//// unsigned
//ulong r = ulong.MaxValue;
//short s = short.MaxValue;
//short s1 = short.MinValue;

//Console.WriteLine(s);
//Console.WriteLine(s1);

// Math

//int a = 1;
//int b = Math.Min(1, 2);


//double a = 1.6;

//Console.WriteLine("Round: " + Math.Round(a)); 
//Console.WriteLine("Truncate: " + Math.Truncate(a)); 
//Console.WriteLine("Floor: " + Math.Floor(a));
//Console.WriteLine("Ceiling: " + Math.Ceiling(a));

//double a = 125; // 5 * 5 * 5
//Console.WriteLine(Math.Cbrt(a)); // 5


// operators with strings
//string a = "Hello";
//string b = "Wolrd";

//string c = a + b;
//a += b;

//Console.WriteLine(c);
//Console.WriteLine(a);

// operators with bools
//bool cash = false;
//bool card = false;

//Console.WriteLine(!cash && !card);
//Console.WriteLine(true && true);

//int a = 10;
//int b = 12;
//Console.WriteLine(a != b);

// int, long - numbers
// string - text/string
// DateTime 

//DateTime date = DateTime.Now;
//int minute = date.Minute;
//int day = date.Day;
//int year = date.Year;

//Console.WriteLine("Minutes: " + minute);
//Console.WriteLine("Days: " + day);
//Console.WriteLine("Year: " + year);

DateTime januaryFirst = new DateTime(2023, 1, 1);
DateTime today = DateTime.Now.Date;

Console.WriteLine(today > januaryFirst);