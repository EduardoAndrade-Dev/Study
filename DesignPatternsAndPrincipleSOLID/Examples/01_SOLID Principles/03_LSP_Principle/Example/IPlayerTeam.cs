using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._03_LSP_Principle.Example
{
    public interface IPlayerTeam : IPlayer
    {

        public void AssignTeam(Team team);
        public string GetTeam();

    }
}
