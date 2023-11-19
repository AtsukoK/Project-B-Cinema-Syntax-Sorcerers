public class Show
{

    public int RoomID;
    public List<Chair> Chairs;
    public Movie Movie;

    public Show(int roomid, List<Chair> chairs, Movie movie)
    {
        RoomID = roomid;
        Chairs = chairs;
        Movie = movie;
    }
}