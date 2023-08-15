namespace inter.Models
{
    public class Agents
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //navigation properties
        public virtual List<Players> Players { get; set; } = null!;
    }
}
