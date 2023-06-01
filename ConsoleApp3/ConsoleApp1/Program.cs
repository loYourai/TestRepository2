// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Team!");



Stack<string> stack = new Stack<string>();

//method
//{
//    if ()()
//    {
        //}
//}

stack.Push("a");
stack.Push("b");
stack.Push("c");

//stack.Pop();

while (stack.TryPop(out var item))
{
    Console.WriteLine(item);
}

//Queue<string> queue = new Queue<string>();

//queue.Enqueue("a");
//queue.Enqueue("b"); 
//queue.Enqueue("c");


//while (queue.TryDequeue(out var item)) 
//{
//    Console.WriteLine(item);
//}

//queue.Enqueue("456");



//var set = new HashSet<string>();
//var set2 = new HashSet<string>();

//set.Add("a");
//set.Add("a");


//for (int i = 0; i < 10; i++)
//{
//    set.Add(i.ToString());
//    set2.Add((i + 4).ToString());
//}

//var resultSet = set2.Intersect(set);


//Console.WriteLine(resultSet.Count());

//Dictionary<int, string> dictionary = new Dictionary<int, string>();

//for (int i = 0; i < 10; i++)
//{
//    dictionary.Add(i + 1, i.ToString());
//}

//dictionary[100] = "100";

////foreach (var item in dictionary)
////{
////    Console.WriteLine($"{item.Key}: {item.Value}");
////}

//dictionary.TryGetValue(1, out var str);

//Console.WriteLine(str);

//var list = new List<string>();

//for(int i = 0; i < 10; i++)
//{
//    list.Add(i.ToString());
//}

////list.Remove("2");
////list.RemoveAt(0);

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

////list.Clear();
//foreach (var item in new string[] { "11", "12" })
//{
//    list.Insert(0, item);
//}

//list.Reverse();

Console.ReadLine();

