public class ChairInfo
{
    public int Row;
    public int ChairInTheRow;

    public ChairInfo(int row, int chairInTheRow)
    {
        Row = row;
        ChairInTheRow = chairInTheRow;
    }
}

public class CheckOutObj
{
    public string CustomerName; 
    public string MovieName;
    public int Hall;
    public List<ChairInfo> ChairInfoList;  
    public double totalCost;
    public DateTime MovieStartDate;
    public DateTime MovieEndDate;

    public CheckOutObj(string customerName, string moviename, int hall, List<ChairInfo> chairInfoList, double totalCost, DateTime movieStartDate, DateTime movieEndDate)
    {
        CustomerName = customerName;
        MovieName = moviename;
        Hall = hall;
        ChairInfoList = chairInfoList;
        this.totalCost = totalCost;
        MovieStartDate = movieStartDate;
        MovieEndDate = movieEndDate;
    }
}
