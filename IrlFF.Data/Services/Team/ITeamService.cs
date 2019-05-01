using IrlFF.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrlFF.Data.Services
{
    public interface ITeamService
    {
        void Initialize();

        Team AddTeam(Team t);

        Team GetTeamById(int id);

        IList<Team> GetTeams(string orderBy = null);

        bool UpdateTeam(Team t);

        void UpdateTeamPoints();

    }
}
