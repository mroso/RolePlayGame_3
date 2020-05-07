using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class MagicCharacter: Character
    {
        protected List<IMagicalItem> MagicalItems = new List<IMagicalItem>();
        public virtual void AddItem(IMagicalItem item)
        {
            this.MagicalItems.Add(item);
        }

        public virtual void RemoveItem(IMagicalItem item)
        {
            this.MagicalItems.Remove(item);
        }
    }
}
