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
                Password = "Password1!",
                Role = Role.Administrator
            });

            userSvc.RegisterUser(new User
            {
                UserName = "stephen",
                Password = "Password1!",
                Role = Role.User
            });

            userSvc.RegisterUser(new User
            {
                UserName = "JohnDoe",
                Password = "Password1!",
                Role = Role.User
            });

            userSvc.RegisterUser(new User
            {
                UserName = "JaneDoe",
                Password = "Password1!",
                Role = Role.User
            });
            #endregion

            #region Seed Players
            #region Derry GK + Defenders
            playerSvc.AddPlayer(new Player
            {
                Forename = "Peter",
                Surname = "Cherrie",
                TotalPoints = 4,
                Position = Position.Goalkeeper,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Nathan",
                Surname = "Gartside",
                TotalPoints = 2,
                Position = Position.Goalkeeper,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Rhys",
                Surname = "McDermott",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Connor",
                Surname = "McDermott",
                TotalPoints = 4,
                Position = Position.Defender,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Ciaran",
                Surname = "Coll",
                TotalPoints = 1,
                Position = Position.Defender,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Eoin",
                Surname = "Toal",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Patrick",
                Surname = "McClean",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Darren",
                Surname = "Cole",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Josh",
                Surname = "Kerr",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Ally",
                Surname = "Gilchrist",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 3,
            });
            #endregion

            #region Derry Midfielders
            playerSvc.AddPlayer(new Player
            {
                Forename = "Brendan",
                Surname = "Barr",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Conor",
                Surname = "Gormley",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Ciaron",
                Surname = "Harkin",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Greg",
                Surname = "Sloggett",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Jamie",
                Surname = "McDonagh",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Gerardo",
                Surname = "Bruna",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Adrian",
                Surname = "Delap",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Evan",
                Surname = "Tweed",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Shane",
                Surname = "McNamee",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Gianni",
                Surname = "Seraf",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Barry",
                Surname = "McNamee",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Ronan",
                Surname = "McKinley",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 3,
            });
            #endregion

            #region Derry Attackers
            playerSvc.AddPlayer(new Player
            {
                Forename = "David",
                Surname = "Parkhouse",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Michael",
                Surname = "McCrudden",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Junior",
                Surname = "Ogedi-Uzokwe",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 3,
            });
            playerSvc.AddPlayer(new Player
            {
                Forename = "Eoghan",
                Surname = "Stokes",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 3,
            });
            #endregion
            #endregion

            #region Seed Teams
            teamSvc.AddTeam(new Team
            {
                Forename = "Stephen",
                Surname = "McGowan",
                TeamName = "Stephen's LOI Team",
                TotalPoints = 5,
                UserId = 2
            });

            teamSvc.AddTeam(new Team
            {
                Forename = "John",
                Surname = "Doe",
                TeamName = "Johns's LOI Team",
                TotalPoints = 40,
                UserId = 3
            });

            teamSvc.AddTeam(new Team
            {
                Forename = "Jane",
                Surname = "Doe",
                TeamName = "Jane's LOI Team",
                TotalPoints = 25,
                UserId = 4
            });
            #endregion

            #region Seed TeamPlayers
            teamPlayerSvc.AddTeamPlayer(2, 1);
            teamPlayerSvc.AddTeamPlayer(2, 4);
            teamPlayerSvc.AddTeamPlayer(2, 6);
            teamPlayerSvc.AddTeamPlayer(2, 7);
            teamPlayerSvc.AddTeamPlayer(2, 8);
            teamPlayerSvc.AddTeamPlayer(2, 13);
            teamPlayerSvc.AddTeamPlayer(2, 14);
            teamPlayerSvc.AddTeamPlayer(2, 15);
            teamPlayerSvc.AddTeamPlayer(2, 17);
            teamPlayerSvc.AddTeamPlayer(2, 20);
            teamPlayerSvc.AddTeamPlayer(2, 22);
            #endregion  
        }
    }
}