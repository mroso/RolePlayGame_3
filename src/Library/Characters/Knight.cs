using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: Character, IHeroes
    {
        private int InitialHealth = 100;
        public int VictoryPoints { get; set; }

        public Knight(string name)
        {
            this.Name = name;
            
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
        
        public override void Cure()
        {
            this.Health = this.InitialHealth;
        }

    }
}