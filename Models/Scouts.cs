namespace inter.Models
{
    public class Scouts
    {
        public int ScoutID { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        //navigation properties
        public virtual List<Players> Players { get; set; }
        public virtual List<ScoutsTeams> ScoutsTeams { get; set; }
    }
}
