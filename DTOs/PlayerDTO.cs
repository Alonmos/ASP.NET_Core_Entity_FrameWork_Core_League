namespace inter.DTOs
{
    public class PlayerDTO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TeamID { get; set; }
        public int ScoutID { get; set; }
    }
}
