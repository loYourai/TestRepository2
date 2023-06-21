// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Xml.Serialization;

IController controller = new MenuItemController();

while (controller != null)
{
    controller = controller.ExecuteAction();
}

var xmlFileName = "xmlFile.xml";
var jsonFileName = "jsonFile.json";



//XmlSerializer serializer = new XmlSerializer(typeof(Person));
var person = new Person
{
    
    }
};


JsonSerializer serializer = new JsonSerializer();
serializer.Converters.Add(new JavaScriptDateTimeConverter());
serializer.NullValueHandling = NullValueHandling.Ignore;


public class MyObject
{
    public List<Person> Persons1 { get; set; }

    public List<Address> Address { get; set; }
}



    List<Person> list = new List<Person>();
list.Add(person);
list.Add(person);

var myObject = new MyObject
{
    Persons1 = list,
    Address = new List<Address>
    {

    }
}



using (StreamWriter sw = new StreamWriter(jsonFileName))
using (JsonWriter writer = new JsonTextWriter(sw))
{
    serializer.Serialize(writer, list);
}

using (var sw = new StreamReader(jsonFileName))
using (var writer = new JsonTextReader(sw))
{
    var deserialedList =  serializer.Deserialize<List<Person>>(writer);
    Console.ReadLine();
}


/*
using (var streamWriter = new StreamWriter(xmlFileName))
{
     serializer.Serialize(streamWriter, list);

}


using (var streamWriter = new StreamReader(xmlFileName))
{
    var desearilizedPerson = serializer.Deserialize(streamWriter);
    Console.ReadLine();

}
*/





Console.WriteLine("Execution has ended");
Console.ReadLine();

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
}

