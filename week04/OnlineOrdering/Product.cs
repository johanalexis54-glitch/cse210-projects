using System;
using System.Net.Sockets;
public class Product
{
    private string name;
    private int _id;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity, )
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    
    public string GetName() => _name;
    public int GetId() => _id;

    public decimal GetTotalCost()
    {
        return _price * _quiantity;
     
    }

}