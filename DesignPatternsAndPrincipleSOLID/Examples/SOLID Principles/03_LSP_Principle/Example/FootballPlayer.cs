using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._03_LSP_Principle.Example
{
    public class FootballPlayer : Player, IPlayerTeam
    {
        private Team Team { get; set; }

        public void AssignTeam(Team team)
        {
            Team = team;
        }

        public string GetTeam() => Team.Name;

        public string GetMarketValue(PlayerCategory category)
        {
            string marketValue = "";
            switch (category)
            {
                case PlayerCategory.Amateur:
                    marketValue = "100";
                    break;
                case PlayerCategory.Professional:
                    marketValue = "1000";
                    break;
            }
            return marketValue;
        }
    }
}
