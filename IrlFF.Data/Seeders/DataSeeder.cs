using IrlFF.Data.Models;
using IrlFF.Data.Services;

namespace IrlFF.Data
{
    public class DataSeeder
    {
        private readonly PlayerService svc;

        public DataSeeder(PlayerService svc)
        {
            this.svc = svc;
            svc.Initialize();
        }

        public void Seed()
        {
                //Club c = svc.AddClub(new Club
                //{
                //    ClubName = "Derry City"
                //});

                //Player p = svc.AddPlayer(new Player
                //{
                //    Forename = "Barry",
                //    Surname = "McNamee",
                //    WeekPoints = 12,
                //    TotalPoints = 14,
                //    ClubId = 1,
                //    PlayerValue = 6.50,
                //    Position = Position.Midfielder
                //});

                //svc.AddTeam(new Team
                //{
                //    Owner = "Stephen McGowan",
                //    TeamName = "LOI Select"
                //});

            }
        }
}
