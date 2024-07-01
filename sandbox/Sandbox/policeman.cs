class Policeman : person
{ 
    private string _cirtification;

    public Policeman(string cirtification, string firstName, string lastName, int age, int weight) : base(firstName, lastName, age, weight)
    {
        _cirtification = cirtification;
    }
    public string PolicemanInformation()
    {
        return $"{_cirtification}, {PersonInformantion()}";
    }
}