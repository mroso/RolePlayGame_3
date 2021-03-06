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
            while (AreAlive (goodGuys) && AreAlive(badGuys))
            {
                Turn (badGuys);

                if (AreAlive (goodGuys))
                {
                    Turn (goodGuys);
                }
            }
        }
        void Turn (List<IEnemies> badGuys)
        { // -Si hay un solo Heroe ,todos los enemigos lo  atacan.
            if (this.goodGuys.Count == 1 && this.badGuys.Count >= 1)
            {
                foreach (Character enemy in badGuys)
                {
                    ((Character) (goodGuys[0])).ReceiveAttack (enemy.AttackValue);

                    // -Si el Heroe muere se quita de la Lista de Heroes vivos
                    if (IsDead (((Character) goodGuys[0])))
                    {
                        RemoveCharacter (goodGuys[0]);
                        break;
                    }
                }
            }
            // -Si hay mas de un Heroe , los enemigos atacan uno a uno a cada Heroe.
            else
            {
                for (int i = 0; i < badGuys.Count; i++)
                {
                    int indexHeroe = i % goodGuys.Count;

                    ((Character) goodGuys[indexHeroe]).ReceiveAttack (((Character) badGuys[i]).AttackValue);

                    // -Si el Heroe muere se quita de su Lista de Heroes vivos
                    if (IsDead (((Character) goodGuys[indexHeroe])))
                    {
                        RemoveCharacter (goodGuys[indexHeroe]);
                    }
                }
            }
        }
        void Turn (List<IHeroes> goodGuys)
        { //cada heroe ataca a un enemigo

            foreach (Character heroe in goodGuys)
            {
                List<IEnemies> killedEnemies = new List<IEnemies> ();
                
                foreach (Character enemy in badGuys)
                {
                    int heroeAtack = heroe.AttackValue; //toma el valor de ataque de cada heroe en goodguys
                    enemy.ReceiveAttack (heroeAtack);

                    //si el enemigo muere se quita de la lista y se le da los VP a el Heroe
                    if (IsDead (enemy))
                    {
                        killedEnemies.Add((IEnemies)enemy);
                        ((IHeroes) heroe).VictoryPoints += ((IEnemies) enemy).VictoryPoints;
                    }
                }
                foreach (IEnemies enemy in killedEnemies)
                {
                    RemoveCharacter ((IEnemies) enemy);
                }
            }
        }
        bool IsDead (Character character)
        {
            return character.Health == 0;
        }
        bool AreAlive (List<IEnemies> characters)
        {
            return characters.Count > 0;
        }
        bool AreAlive (List<IHeroes> characters)
        {
            return characters.Count > 0;
        }
    }
}