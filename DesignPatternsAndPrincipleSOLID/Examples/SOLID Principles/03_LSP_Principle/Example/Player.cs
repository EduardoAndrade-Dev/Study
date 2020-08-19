using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._03_LSP_Principle.Example
{
    public class Player : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }

        public void SetCategory(PlayerCategory category)
        {
            Category = category;
        }
    }
}
