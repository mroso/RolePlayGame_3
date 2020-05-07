using System.Collections.Generic;
namespace RoleplayGame
{

/* Aplicamos herencia para que los orcos sean un character y un enemigo. Tiene esos metodos y atributos.
*/
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