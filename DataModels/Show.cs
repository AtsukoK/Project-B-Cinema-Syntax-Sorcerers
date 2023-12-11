public class Show
{


    public List<Chair> Chairs;
    public String Moviename;
    public String ChairsFileName;

    public DateTime MovieStartDate;
    public DateTime MovieEndDate;
    public int HallType;

    public Show(List<Chair> chairs, String movie, string filename, DateTime start, DateTime end, int halltype)
    {
        Chairs = chairs;
        Moviename = movie;
        ChairsFileName = filename;
        MovieStartDate = start;
        MovieEndDate = end;
        HallType = halltype;



    }
}