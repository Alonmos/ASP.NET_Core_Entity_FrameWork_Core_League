namespace inter.Models
{
    public class ScoutsTeams
    {
        public int ScoutsID { get; set; }
        public int TeamsID { get; set; }
        public DateTime StartDate { get; set; }

        //navigation properties
        public Scouts Scouts { get; set; }
        public Teams Teams { get; set; }
    }
}
