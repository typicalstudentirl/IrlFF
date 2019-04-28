using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using IrlFF.Data.Services;

namespace IrlFF.Data
{
    public class DataSeeder
    {
        private readonly IPlayerService playerSvc;

        private readonly IClubService clubSvc;

        private readonly ITeamService teamSvc;

        private readonly ITeamPlayerService teamPlayerSvc;

        private readonly IUserService userSvc;

        public DataSeeder()
        {
            playerSvc = new PlayerService(FFDbContextFactory.CreateCtx());
            clubSvc = new ClubService(FFDbContextFactory.CreateCtx());
            teamSvc = new TeamService(FFDbContextFactory.CreateCtx());
            userSvc = new UserService(FFDbContextFactory.CreateCtx());
            teamPlayerSvc = new TeamPlayerService(FFDbContextFactory.CreateCtx());
            playerSvc.Initialize();
        }

        public DataSeeder(FFDbContext _ctx)
        {
            playerSvc = new PlayerService(_ctx);
            clubSvc = new ClubService(_ctx);
            teamSvc = new TeamService(_ctx);
            userSvc = new UserService(_ctx);
            teamPlayerSvc = new TeamPlayerService(_ctx);
            playerSvc.Initialize();
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
            //#region Derry GK + Defenders
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Peter",
            //    Surname = "Cherrie",
            //    TotalPoints = 4,
            //    Position = Position.Goalkeeper,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Nathan",
            //    Surname = "Gartside",
            //    TotalPoints = 2,
            //    Position = Position.Goalkeeper,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Rhys",
            //    Surname = "McDermott",
            //    TotalPoints = 0,
            //    Position = Position.Defender,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Connor",
            //    Surname = "McDermott",
            //    TotalPoints = 4,
            //    Position = Position.Defender,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Ciaran",
            //    Surname = "Coll",
            //    TotalPoints = 1,
            //    Position = Position.Defender,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Eoin",
            //    Surname = "Toal",
            //    TotalPoints = 0,
            //    Position = Position.Defender,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Patrick",
            //    Surname = "McClean",
            //    TotalPoints = 0,
            //    Position = Position.Defender,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Darren",
            //    Surname = "Cole",
            //    TotalPoints = 0,
            //    Position = Position.Defender,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Josh",
            //    Surname = "Kerr",
            //    TotalPoints = 0,
            //    Position = Position.Defender,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Ally",
            //    Surname = "Gilchrist",
            //    TotalPoints = 0,
            //    Position = Position.Defender,
            //    ClubId = 3,
            //});
            //#endregion

            //#region Derry Midfielders
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Brendan",
            //    Surname = "Barr",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Conor",
            //    Surname = "Gormley",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Ciaron",
            //    Surname = "Harkin",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Greg",
            //    Surname = "Sloggett",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Jamie",
            //    Surname = "McDonagh",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Gerardo",
            //    Surname = "Bruna",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Adrian",
            //    Surname = "Delap",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Evan",
            //    Surname = "Tweed",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Shane",
            //    Surname = "McNamee",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Gianni",
            //    Surname = "Seraf",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Barry",
            //    Surname = "McNamee",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Ronan",
            //    Surname = "McKinley",
            //    TotalPoints = 0,
            //    Position = Position.Midfielder,
            //    ClubId = 3,
            //});
            //#endregion

            //#region Derry Attackers
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "David",
            //    Surname = "Parkhouse",
            //    TotalPoints = 0,
            //    Position = Position.Forward,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Michael",
            //    Surname = "McCrudden",
            //    TotalPoints = 0,
            //    Position = Position.Forward,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Junior",
            //    Surname = "Ogedi-Uzokwe",
            //    TotalPoints = 0,
            //    Position = Position.Forward,
            //    ClubId = 3,
            //});
            //playerSvc.AddPlayer(new Player
            //{
            //    Forename = "Eoghan",
            //    Surname = "Stokes",
            //    TotalPoints = 0,
            //    Position = Position.Forward,
            //    ClubId = 3,
            //});
            //#endregion
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
            teamPlayerSvc.AddTeamPlayer(2, 23);
            teamPlayerSvc.AddTeamPlayer(2, 24);
            #endregion  
        }
    }
}