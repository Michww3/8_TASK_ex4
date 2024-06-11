using System.Xml.Serialization;

public class User
{
    //[XmlAttribute]
    public string name { get; set; }
    //[XmlAttribute]
    public int age { get; set; }

    public User() { }

    public User(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(User));

        User user;
        using (StreamReader reader = new StreamReader("C:\\Users\\User\\Desktop\\User.xml"))
        {
            user = (User)serializer.Deserialize(reader);
        }

        Console.WriteLine($"Имя: {user.name}, Возраст: {user.age}");
    }
}
