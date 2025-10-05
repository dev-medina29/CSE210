using System;
using System.Collections.Generic;
class Product
{
    private string name;
    private float price;
    private string product_id;
    private int quantity;
    public Product(string Name, float Price, string Product_id, int Quantity)
    {
        name = Name;
        price = Price;
        product_id = Product_id;
        quantity = Quantity;
    }

    public float TotalCost()
    {
        return price * quantity;
    }
    public string GetProductID()
    {
        return product_id;
    }
}