public class CinemaRoom
{

    public int RoomID;
    public List<Chair> Chairs;
    public List<Movie> Movies;

    public CinemaRoom(int roomid, List<Chair> chairs, List<Movie> movies)
    {
        RoomID = roomid;
        Chairs = chairs;
        Movies = movies;
    }
}