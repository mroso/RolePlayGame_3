using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{

    /* Clase donde se realiza el encuentro entre heroes y enemigos 
     */
    public class Encounters

    {
        public List<IHeroes> goodGuys = new List<IHeroes> ();
        public List<IEnemies> badGuys = new List<IEnemies> ();

        public void AddCharacter (IHeroes hero)
        {
            this.goodGuys.Add (hero);
        }
        public void AddCharacter (IEnemies enemy)
        {
            this.badGuys.Add (enemy);
        }

        public void RemoveCharacter (IHeroes hero)
        {
            this.goodGuys.Remove (hero);
        }
        public void RemoveCharacter (IEnemies enemy)
        {
            this.badGuys.Remove (enemy);
        }
        public void DoEncounter ()
        {
            while (AllAlive (goodGuys) && AllAlive (badGuys))
            {
                Turn (badGuys);

                if (AllAlive (goodGuys))
                {
                    Turn (goodGuys);
                }
            }

        }
        bool AllAlive (List<Character> characters)
        {
            return character.Count () > 0;

        }
        void Turn (List<IEnemies> badGuys)
            {   // -Todos los enemigos atacan a un solo Heroe
                if (goodGuys.Count () = 1 && badGuys.Count () > 1)
                {
                    foreach (Character enemy in badGuys)
                    {
                        // -Si el Heroe muere se quita de su Lista
                        (Character) goodGuys[0].ReceiveAttack (enemy);
                        if ((Character) goodGuys[0].Health == 0)
                        {
                            RemoveCharacter(goodGuys[0]);
                            break;
                        }
                     
                    }                     
                }
                // -Los enemigos atacan a uno a uno a cada Heroe
                else 
                {



                }
            }
    }
}