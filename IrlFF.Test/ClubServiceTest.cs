using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class ClubServiceTest
    {
        private readonly IClubService svc;

        public ClubServiceTest()
        {
            svc = new ClubService();
            //Restore test data to DB before each test
            svc.Initialize();
        }

        [Fact]
        public void Add_New_Club_To_Empty_DB_Should_Be_Found_By_Id()
        {
            Club c = new Club { ClubName = "Bohemian FC" };

            c = svc.AddClub(c);

            Club newClub = svc.GetClubById(c.Id);

            Assert.Equal(c.Id, newClub.Id);
        }

        [Fact]
        public void Add_New_Clubs_To_Empty_DB_Should_Be_Found()
        {
            Club c = new Club { ClubName = "Test Club" };

            c = svc.AddClub(c);

            IList<Club> clubs = svc.GetClubs();

            Assert.True(clubs.Contains(c));
        }

        [Fact]
        public void Add_New_Club_To_Empty_DB_Then_Delete_Should_Not_Be_Found()
        {
            Club c = new Club { ClubName = "Bohemian FC" };

            c = svc.AddClub(c);

            Club newClub = svc.GetClubById(c.Id);

            svc.DeleteClub(newClub.Id);

            Assert.Null(svc.GetClubById(c.Id));
        }
    }
}
