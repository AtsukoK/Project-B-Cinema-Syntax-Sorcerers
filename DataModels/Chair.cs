using System.Data.Common;

public class Chair
{
    public int ID;
    public double Price;
    public bool IsReserved;
    public int Row;

    public Chair(int id, double price, bool isreserved, int row)
    {
        ID = id;
        Price = price;
        IsReserved = isreserved;
        Row = row;


    }
}