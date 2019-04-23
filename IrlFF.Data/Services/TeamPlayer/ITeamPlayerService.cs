using IrlFF.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrlFF.Data.Services
{
    public interface ITeamPlayerService
    {
        void Initialize();

        TeamPlayer AddTeamPlayer(int TeamId, int PlayerId);

        IList<Player> GetPlayersByTeamId(int id);

        bool DeleteTeamPlayer(int playerId, int userId);
    }
}
