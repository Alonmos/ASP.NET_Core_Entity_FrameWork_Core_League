﻿namespace inter.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int TeamID { get; set; }

        //navigation props
        public virtual Teams Teams { get; set; }
    }
}
