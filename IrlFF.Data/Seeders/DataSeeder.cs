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

            #region Seed Teams
            teamSvc.AddTeam(new Team
            {
                Forename = "Stephen",
                Surname = "McGowan",
                TeamName = "Stephen's LOI Team",
                WeekPoints = 0,
                TotalPoints = 0,
                UserId = 2
            });

            teamSvc.AddTeam(new Team
            {
                Forename = "John",
                Surname = "Doe",
                TeamName = "Johns's LOI Team",
                WeekPoints = 0,
                TotalPoints = 0,
                UserId = 3
            });

            teamSvc.AddTeam(new Team
            {
                Forename = "Jane",
                Surname = "Doe",
                TeamName = "Jane's LOI Team",
                WeekPoints = 0,
                TotalPoints = 0,
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

            teamPlayerSvc.AddTeamPlayer(3, 2);
            teamPlayerSvc.AddTeamPlayer(3, 5);
            teamPlayerSvc.AddTeamPlayer(3, 6);
            teamPlayerSvc.AddTeamPlayer(3, 7);
            teamPlayerSvc.AddTeamPlayer(3, 8);
            teamPlayerSvc.AddTeamPlayer(3, 13);
            teamPlayerSvc.AddTeamPlayer(3, 14);
            teamPlayerSvc.AddTeamPlayer(3, 15);
            teamPlayerSvc.AddTeamPlayer(3, 17);
            teamPlayerSvc.AddTeamPlayer(3, 23);
            teamPlayerSvc.AddTeamPlayer(3, 24);

            teamPlayerSvc.AddTeamPlayer(4, 2);
            teamPlayerSvc.AddTeamPlayer(4, 3);
            teamPlayerSvc.AddTeamPlayer(4, 4);
            teamPlayerSvc.AddTeamPlayer(4, 5);
            teamPlayerSvc.AddTeamPlayer(4, 6);
            teamPlayerSvc.AddTeamPlayer(4, 13);
            teamPlayerSvc.AddTeamPlayer(4, 14);
            teamPlayerSvc.AddTeamPlayer(4, 15);
            teamPlayerSvc.AddTeamPlayer(4, 17);
            teamPlayerSvc.AddTeamPlayer(4, 26);
            teamPlayerSvc.AddTeamPlayer(4, 22);
            #endregion  
        }
    }
}