
using GetterSetterAssignment;

public class mainClass
{
    public static void Main(String[] args)
    {
        PersonClassWithConstructor personClassWithConstructor = new PersonClassWithConstructor("Prerna", 22);
        Console.WriteLine(personClassWithConstructor.Name + " " +personClassWithConstructor.Age);

        PersonClassWithAutoImplementedProperties autoImplementedPropertiesPersonClass = new PersonClassWithAutoImplementedProperties();
        autoImplementedPropertiesPersonClass.Name = "Charvi";
        autoImplementedPropertiesPersonClass.Age = 18;
        Console.WriteLine(autoImplementedPropertiesPersonClass.Name + " " + autoImplementedPropertiesPersonClass.Age);

        PersonClassWithPrivateSetters personClassWithPrivate = new PersonClassWithPrivateSetters("Ashika", 23);
        Console.WriteLine(personClassWithPrivate.Name + " " + personClassWithPrivate.Age);

        Person person = new Person
        {
            Name = "Jainam",
            Age = 14
        };
        Console.WriteLine(person.Name + " " + person.Age);
    }

}




