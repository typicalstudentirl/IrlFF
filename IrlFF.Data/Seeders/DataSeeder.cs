using IrlFF.Data.Models;
using IrlFF.Data.Services;

namespace IrlFF.Data
{
    public class DataSeeder
    {
        private readonly PlayerService playerSvc;

        private readonly ClubService clubSvc;

        private readonly TeamService teamSvc;

        private readonly TeamPlayerService teamPlayerSvc;

        private readonly UserService userSvc;

        public DataSeeder(PlayerService playerSvc, ClubService clubSvc, TeamService teamSvc, TeamPlayerService teamPlayerSvc, UserService userSvc)
        {
            this.playerSvc = playerSvc;
            this.clubSvc = clubSvc;
            this.teamSvc = teamSvc;
            this.userSvc = userSvc;
            this.teamPlayerSvc = teamPlayerSvc;
            playerSvc.Initialize();
            clubSvc.Initialize();
            teamSvc.Initialize();
        }

        public void Seed()
        {
            #region Seed Users
            userSvc.RegisterUser(new User
            {
                UserName = "admin",
                Password = "pass",
                Role = Role.Administrator
            });

            userSvc.RegisterUser(new User
            {
                UserName = "guest",
                Password = "Password1!",
                Role = Role.User
            });

            userSvc.RegisterUser(new User
            {
                UserName = "John Doe",
                Password = "pass",
                Role = Role.User
            });

            userSvc.RegisterUser(new User
            {
                UserName = "Jane Doe",
                Password = "pass",
                Role = Role.User
            });
            #endregion

            #region Seed Clubs
            Club Bohemians = clubSvc.AddClub(new Club
                {
                    ClubName = "Bohemians FC"
                });

                Club Cork = clubSvc.AddClub(new Club
                {
                    ClubName = "Cork City"
                });

                Club Derry = clubSvc.AddClub(new Club
                {
                    ClubName = "Derry City"
                });

                Club Dundalk = clubSvc.AddClub(new Club
                {
                    ClubName = "Dundalk FC"
                });

                Club Harps = clubSvc.AddClub(new Club
                {
                    ClubName = "Finn Harps"
                });

                Club Rovers = clubSvc.AddClub(new Club
                {
                    ClubName = "Shamrock Rovers"
                });

                Club Sligo = clubSvc.AddClub(new Club
                {
                    ClubName = "Sligo Rovers"
                });

                Club Pats = clubSvc.AddClub(new Club
                {
                    ClubName = "St. Pats"
                });

                Club Waterford = clubSvc.AddClub(new Club
                {
                    ClubName = "Waterford"
                });

                Club UCD = clubSvc.AddClub(new Club
                {
                    ClubName = "U.C.D"
                });
            #endregion

            #region Seed Players
            Player p = playerSvc.AddPlayer(new Player
            {
                Forename = "Barry",
                Surname = "McNamee",
                WeekPoints = 12,
                TotalPoints = 14,
                PlayerValue = 6.50,
                Position = Position.Midfielder,
                ClubId = 1,
                Club = null,
                TeamPlayers = null
            });
            #endregion

            #region Seed Teams
            Team t = teamSvc.AddTeam(new Team
            {
                Owner = "Stephen McGowan",
                TeamName = "Stephen's LOI Team",
                TotalPoints = 10,
                UserId = 2
            });

            Team t2 = teamSvc.AddTeam(new Team
            {
                Owner = "John Doe",
                TeamName = "Johns's LOI Team",
                TotalPoints = 40,
                UserId = 3
            });

            Team t3 = teamSvc.AddTeam(new Team
            {
                Owner = "Jane Doe",
                TeamName = "Jane's LOI Team",
                TotalPoints = 25,
                UserId = 4
            });
            #endregion

            #region Seed TeamPlayers
            TeamPlayer tp = teamPlayerSvc.AddTeamPlayer(1, 1);
            #endregion
        }
    }
}