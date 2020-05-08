using System.Collections.Generic;
namespace RoleplayGame
{

/* Aplicamos herencia para que los orcos sean un character y un enemigo. Tiene esos metodos y atributos.
*/
    public class Orcos: Character, IEnemies
    {
        public int VictoryPoints { get;} = 1;

        public Orcos(string name)
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