using System.Collections.Generic;
namespace RoleplayGame
{
    public class Esqueletos: Character, IEnemies
    {
        public int VictoryPoints { get;}

        public Esqueletos(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.AddItem(new Axe());
            this.AddItem(new Bow());

        }

    public override void Cure()
        {
            
        }
    }
}