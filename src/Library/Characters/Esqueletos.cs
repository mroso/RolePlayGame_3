using System.Collections.Generic;
namespace RoleplayGame
{
    public class Esqueletos: Character, IEnemies
    {
        private int InitialHealth = 100;

        public int VictoryPoints { get;}

        public Esqueletos(string name)
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