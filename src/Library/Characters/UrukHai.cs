using System.Collections;
namespace RoleplayGame
{
    public class UrukHai: Character, IEnemies
    {
        public int VictoryPoints { get; } = 2;
        public UrukHai (string name)
        {
            this.Name = name;
            this.Health = 100;
            this.AddItem(new Sword());
            this.AddItem(new Shield());
        }
        public override void Cure()
        {
            
        }
    }
}