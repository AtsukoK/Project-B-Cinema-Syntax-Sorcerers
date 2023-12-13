public class CheckOutObj
{
    public Person PersonObj;
    public Show ShowObj;
    public List<Chair> ChairListObj;

    public CheckOutObj(Person personobj, Show showobj, List<Chair> listchairobj)
    {
        PersonObj = personobj;
        ShowObj = showobj;
        ChairListObj = listchairobj;
    }
}