// See https://aka.ms/new-console-template for more information
using ExtensionsLibrary;


Console.WriteLine("Hello, World!");

//var result = "qwe qwe qwe, test word! Buy".WordCount();

//var inputSpring = "qwe qwe qwe, test word! Buy";
////var result1 = inputSpring.WordCount();

//inputSpring = null;
//var result2 = inputSpring.WordCount();

//Console.WriteLine("True".ToBool());
//Console.WriteLine("False".ToBool());
//Console.WriteLine("true".ToBool());
//Console.WriteLine("123".ToBool());
//Console.WriteLine("".ToBool());

Console.WriteLine(StringExtensions.WordCount(DateTime.Now.AddDays(1).ToString()));


Console.ReadLine();