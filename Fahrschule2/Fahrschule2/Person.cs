namespace Fahrschule2;

public class Person
{
    public string Name { get; set; }
    public string Adresse { get; set; }

    public Person(string name, string adresse)
    {
        Name = name;
        Adresse = adresse;
    }
}