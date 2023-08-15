namespace inter.Models
{
    public class Teams
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public DateTime lastUpdatedDate{ get; set; }


        //navigation properties
        public virtual List<Players> Players { get; set; }
        public virtual List<ScoutsTeams> ScoutsTeams { get; set; }
        public virtual List<Managers> Managers { get; set; }
        public virtual Owner Owner{ get; set; }

    }
}
