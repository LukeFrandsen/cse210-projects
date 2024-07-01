using System.Data;

class person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public string PersonInformantion()
    {
        return $"Name: {_firstName} {_lastName}, Age: {_age}, Weight: {_weight}";
    }

}