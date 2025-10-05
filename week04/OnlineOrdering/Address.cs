using System;
using System.Collections.Generic;
class Address
{
    private string street;
    private string city;
    private string state;
    private string country;
    public Address(string Street, string City, string State, string Country)
    {
        street = Street;
        city = City;
        state = State;
        country = Country;
    }
    public bool IsInUSA()
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetFullAddress()
    {
        return $"{street}\n{city}\n{state}\n{country}";
    }
}