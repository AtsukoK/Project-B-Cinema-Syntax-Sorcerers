public class CheckOutObj
{
    public Person PersonObj;
    public string MovieName;
    // public Show ShowObj;
    public int Hall;
    public List<Chair> ChairListObj;

    public CheckOutObj(Person personobj, string moviename, int hall, List<Chair> listchairobj)
    {
        PersonObj = personobj;
        MovieName = moviename;
        // ShowObj = showobj;
        Hall = hall;
        ChairListObj = listchairobj;
    }
}