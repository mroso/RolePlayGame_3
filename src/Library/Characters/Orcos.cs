using System.Collections.Generic;
namespace RoleplayGame
{
    public class Orcos: Character, IEnemies
    {
        private int InitialHealth = 100;

        public int VictoryPoints { get;}

        public Orcos(string name)
        {
            this.Name = name;
            this.AddItem(new Axe());
            this.AddItem(new Bow());

        }

        public override void Cure()
        {
            
        }
    }
}