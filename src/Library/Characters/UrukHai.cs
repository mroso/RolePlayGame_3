using System.Collections;
namespace RoleplayGame
{
    public class UrukHai: Character, IEnemies
    {
        private int InitialHealth = 100;
        public int VictoryPoints { get; } = 2;
        public UrukHai (string name)
        {
            this.Name = name;
            this.AddItem(new Sword());
            this.AddItem(new Shield());
        }
        public override void Cure()
        {
            
        }
    }
}