using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: MagicCharacter, IHeroes
    {
        private int InitialHealth = 100;
        public int VictoryPoints { get; set; } = 0;

        public Wizard(string name)
        {
            this.Name = name;
            
            this.AddItem(new Staff());
        }

        
        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.Items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                foreach (IMagicalItem item in this.MagicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.Items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.MagicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public override void Cure()
        {
            this.Health = this.InitialHealth;
        }

    }
}