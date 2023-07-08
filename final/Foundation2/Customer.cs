public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
    }

    public void SetCustomerAddress(Address address)
    {
        _address = address;
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public string GetCustomerLocation()
    {
        return _address.DisplayAddress();
    }
    public bool LocationInUSA()
    {
        if (_address.VerifyCountry())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}