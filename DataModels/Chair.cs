using System.Data.Common;

public class Chair
{
    public int ID;
    public double Price;
    public bool IsReserved;

    public Chair(int id, double price, bool isreserved)
    {
        ID = id;
        Price = price;
        IsReserved = isreserved;

    }
}