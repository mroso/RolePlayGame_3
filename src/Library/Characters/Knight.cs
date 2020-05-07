using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: Character
    {
        private int InitialHealth = 100;

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