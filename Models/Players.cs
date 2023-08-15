namespace inter.Models
{
    public class Players
    {
        public int ID { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TeamID { get; set; }
        public int ScoutID { get; set; }


        //navigation properties
        public virtual Teams Teams { get; set; }
        public virtual Scouts Scouts { get; set; }
        public virtual List<Agents> Agents { get; set; }
    }
}
