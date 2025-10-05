using System;
using System.Collections.Generic;
class Order
{
    private List<Product> products = new List<Product>();
    private Customer customers;
    public Order(Customer Customers, List<Product> Products)
    {
        customers = Customers;
        products = Products;
    }
    public double TotalPrice()
    {
        double total = 0;
        if (customers.IsInUSA() == true)
        {
            foreach (var product in products)
            {
                total += product.TotalCost();
            }
            total = total + 5;
        }
        else
        {
            foreach (var product in products)
            {
                total += product.TotalCost();
            }
            total = total + 35;
        }
        return total;
    }
    public string PackingLabel()
    {
        string packing_label = "";
        foreach (var product in products)
        {
            packing_label += $"{product}:{product.GetProductID()}\n";
        }
        return packing_label;
    }
    public string ShippingLabel()
    {
        string shipping_label = "";
        shipping_label += customers.GetAddress();
        return shipping_label; 
    }
    

    
}