using System.Collections.Generic;
namespace RoleplayGame
{

/* Aplicamos herencia para que los orcos sean un character y un enemigo. Tiene esos metodos y atributos.
*/
    public class Troll: Character, IEnemies
    {
        public int VictoryPoints { get;}

        public Troll(string name)
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