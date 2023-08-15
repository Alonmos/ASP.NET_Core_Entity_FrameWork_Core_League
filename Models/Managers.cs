namespace inter.Models
{
    public class Managers
    {
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int Age{ get; set; }
        public int Type { get; set; }
        public int TeamID { get; set; }

        //navigation props
        public virtual Teams Team{ get; set; }
    }
}
