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

        IList<TeamPlayer> GetPlayersByTeamId(int id);
    }
}
