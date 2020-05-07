using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: Character
    {
        private int InitialHealth = 100;

        public Dwarf(string name)
        {
            this.Name = name;
            
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }

        public override void Cure()
        {
            this.Health = this.InitialHealth;
        }


    }
}