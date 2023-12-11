using System.Data.Common;

public class Chair
{
    public int ID;
    public double Price;
    public bool IsReserved;
    public int Row;
    public int ChairInTheRow;

    public Chair(int id, double price, bool isreserved, int row, int chairinrow)
    {
        ID = id;
        Price = price;
        IsReserved = isreserved;
        Row = row;
        ChairInTheRow = chairinrow;



    }
}