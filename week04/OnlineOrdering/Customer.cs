public class Customer
{
    // This are the private members
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // This check if the member live in usa
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // The get in plural
    public string GetName() => _name;
    public Address GetAddress() => _address;
}