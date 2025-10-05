using System;
using System.Collections.Generic;
class Customer
{
    private string name;
    private Address address;
    public Customer(string Name, string street, string city, string state, string country)
    {
        name = Name;
        address = new Address(street, city, state, country);
    }
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
    public string GetAddress()
    {
        return $"{name}\n{address.GetFullAddress()}";
    }
}