using IrlFF.Data.Models;
using IrlFF.Data.Services;

namespace IrlFF.Data
{
    public class PlayerDataSeeder
    {
        private readonly PlayerService playerSvc;

        private readonly ClubService clubSvc;

        private readonly TeamService teamSvc;

        private readonly TeamPlayerService tpSvc;

        public PlayerDataSeeder(PlayerService playerSvc, ClubService clubSvc, TeamService teamSvc)
        {
            this.playerSvc = playerSvc;
            this.clubSvc = clubSvc;
            this.teamSvc = teamSvc;
            playerSvc.Initialize();
            clubSvc.Initialize();
            teamSvc.Initialize();
        }

        public void Seed()
        {
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
        }
    }
}