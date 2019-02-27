using IrlFF.Data.Models;
using System.Collections.Generic;

namespace IrlFF.Data.Services
{
    public interface IPlayerService
    {
        void Initialize();

        List<Player> GetPlayers(string orderBy = null);

        List<Player> GetPlayersByClub(int ClubId);

        Player GetPlayerById(int id);

        Player AddPlayer(Player p);

        bool DeletePlayer(int id);
    }
}
