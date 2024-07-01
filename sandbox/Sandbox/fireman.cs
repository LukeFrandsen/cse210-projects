class Fireman : person
{ 
    private string _cirtification;

    public Fireman(string cirtification, string firstName, string lastName, int age, int weight) : base(firstName, lastName, age, weight)
    {
        _cirtification = cirtification;
    }
    public string FiremanInformation()
    {
        return $"{_cirtification}, {PersonInformantion()}";
    }
}