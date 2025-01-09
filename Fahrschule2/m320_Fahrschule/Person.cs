namespace Fahrschule2;

public class Person
{
    private string Name { get; set; }
    private string Adresse { get; set; }

    public Person(string name, string adresse)
    {
        Name = name;
        Adresse = adresse;
    }
}