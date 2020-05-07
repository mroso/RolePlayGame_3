using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Character
    {
        protected string Name { get; set; }
        private int health = 100;

        public int Health
        {
            get
            {
                return this.health;
            }
            protected set
            {
                this.health = value < 0 ? 0 : value;
            }
        }
        

        public virtual int AttackValue
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
                return value;
            }
        }

        public virtual int DefenseValue
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
                return value;
            }
        }
        protected List<IItem> Items = new List<IItem>();

        public void AddItem(IItem item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.Items.Remove(item);
        }

        public abstract void Cure();
        public virtual int GetDefense()
        {
            int total = this.DefenseValue;
            foreach (IDefenseItem item in Items)
            {
                total += item.DefenseValue;
            }
            return total;

        }

        public void ReceiveAttack(int power)
        {
            int attack = power - this.DefenseValue;
            int damage = attack < 0 ? 0 : attack;
            this.Health -= damage;
        }
    }
}