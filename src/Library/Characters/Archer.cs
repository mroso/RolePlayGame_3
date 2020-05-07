using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Character, IHeroes
    {
        private int InitialHealth = 100;

        public int VictoryPoints { get; set; }

        public Archer(string name)
        {
            this.Name = name;
            
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }

        public override void Cure()
        {
            this.Health = this.InitialHealth;
        }
    }
}