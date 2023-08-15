using Microsoft.EntityFrameworkCore;

namespace inter.Models.Seeds
{
    public class Seeds
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //Teams Seeds
            var T1 = new Teams()
            {
                TeamID = 1,
                Name = "Barcelona",
                lastUpdatedDate = DateTime.Now
            };

            var T2 = new Teams()
            {
                TeamID = 2,
                Name = "Real Madrid",
                lastUpdatedDate = DateTime.Now
            };

            var T3 = new Teams()
            {
                TeamID = 3,
                Name = "Atletico Madrid",
                lastUpdatedDate = DateTime.Now
            };

            var T4 = new Teams()
            {
                TeamID = 4,
                Name = "Valencia",
                lastUpdatedDate = DateTime.Now
            };

            modelBuilder.Entity<Teams>().HasData(T1, T2, T3, T4);

            //Managers Seeds
            var M1 = new Managers()
            {
                Id = 1,
                FirstName = "Pep",
                LastName = "Guardiola",
                Age = 50,
                TeamID = 1
            };

            var M2 = new Managers()
            {
                Id = 2,
                FirstName = "Carlo",
                LastName = "Ancelotti",
                Age = 54,
                TeamID = 3
            };

            var M3 = new Managers()
            {
                Id = 3,
                FirstName = "Diego",
                LastName = "Simeone",
                Age = 46,
                TeamID = 4
            };

            modelBuilder.Entity<Managers>().HasData(M1, M2, M3);

            //Players Seeds
            var P2 = new Players()
            {
                ID = 4,
                FirstName = "Luca",
                LastName = "Modric",
                DateOfBirth = DateTime.Now, 
                TeamID=3,
                ScoutID= 2,
            };

            var P3 = new Players()
            {
                ID = 5,
                FirstName = "Toni",
                LastName = "Kroos",
                DateOfBirth = DateTime.Now,
                TeamID = 3,
                ScoutID = 2,
            };

            modelBuilder.Entity<Players>().HasData(P2, P3);

            //Scouts Seeds
            var S1 = new Scouts()
            {
                ScoutID = 1,
                FirstName = "Randum",
                LastName = "Name",
                Age = 44
            };

            var S2 = new Scouts()
            {
                ScoutID = 2,
                FirstName = "Scout",
                LastName = "Name",
                Age = 33
            };

            modelBuilder.Entity<Scouts>().HasData(S1, S2);

            //ScoutsTeams Seeds
            var ST1 = new ScoutsTeams()
            {
                ScoutsID = 1,
                TeamsID = 1,
                StartDate = DateTime.Now
            };

            var ST2 = new ScoutsTeams()
            {
                ScoutsID = 1,
                TeamsID = 3,
                StartDate = DateTime.Now
            };

            var ST3 = new ScoutsTeams()
            {
                ScoutsID = 2,
                TeamsID = 1,
                StartDate = DateTime.Now
            };

            var ST4 = new ScoutsTeams()
            {
                ScoutsID = 2,
                TeamsID = 3,
                StartDate = DateTime.Now
            };

            var ST5 = new ScoutsTeams()
            {
                ScoutsID = 2,
                TeamsID = 4,
                StartDate = DateTime.Now
            };

            modelBuilder.Entity<ScoutsTeams>().HasData(ST1, ST2, ST3, ST4, ST5);

            var O1 = new Owner()
            {
                OwnerID = 1,
                FirstName = "WW",
                LastName = "QQ",
                Age = 40,
                TeamID = 1
            };

            var O2 = new Owner()
            {
                OwnerID = 2,
                FirstName = "EE",
                LastName = "TT",
                Age = 42,
                TeamID = 3
            };

            var O3 = new Owner()
            {
                OwnerID = 3,
                FirstName = "UU",
                LastName = "OO",
                Age = 47,
                TeamID = 4
            };

            modelBuilder.Entity<Owner>().HasData(O1, O2, O3);

            var A1 = new Agents()
            {
                Id = 1,
                FirstName = "VVV",
                LastName = "HHH"
            };

            modelBuilder.Entity<Agents>().HasData(A1);

            modelBuilder.Entity("AgentsPlayers").HasData(

                new Dictionary<string, object>
                {
                    ["AgentsId"] = A1.Id,
                    ["PlayersID"] = P2.ID,
                },

                new Dictionary<string, object>
                {
                    ["AgentsId"] = A1.Id,
                    ["PlayersID"] = P3.ID,
                }
                );

        }
    }
}
