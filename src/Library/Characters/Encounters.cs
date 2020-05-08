using System.Collections;

using System.Collections.Generic;

namespace RoleplayGame
{

/* Clase donde se realiza el encuentro entre heroes y enemigos 
*/
    public class Encounters

    {
        public List<IHeroes> goodGuys = new List<IHeroes>();
        public List<IEnemies> badGuys = new List<IEnemies>();
        
        public void AddCharacter (IHeroes hero)
        {
            this.goodGuys.Add(hero);
        }
        public void AddCharacter (IEnemies enemy)
        {
            this.badGuys.Add(enemy);
        }

        public void RemoveCharacter (IHeroes hero)
        {
            this.goodGuys.Remove(hero);
        }
        public void RemoveCharacter (IEnemies enemy)
        {
            this.badGuys.Remove(enemy);
        }
        public void DoEncounter()
        {

        }
    }
}