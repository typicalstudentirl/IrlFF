using IrlFF.Data.Models;
using System.Collections.Generic;

namespace IrlFF.Data.Services
{
    public interface IClubService
    {
        void Initialize();

        Club AddClub(Club c);

        Club GetClubById(int id);

        IList<Club> GetClubs();
        
        bool DeleteClub(int id);
    }
}
