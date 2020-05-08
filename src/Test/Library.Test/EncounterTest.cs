using System;
using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class EncounterTests
    {
        [Test]
        public void OneVsOneEnemyAttacksOnce()
        {
            Encounters oneVersusOne = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            merlin.AddItem(new Staff());
            UrukHai urukHai = new UrukHai ("Bad guy");
            oneVersusOne.AddCharacter((IHeroes)merlin);
            oneVersusOne.AddCharacter((IEnemies)urukHai);

            oneVersusOne.DoEncounter();

            Assert.AreEqual(merlin.Health, 80);
        }
        [Test]
        public void OneVsOneHeroWins()
        {
            Encounters oneVersusOne = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            UrukHai urukHai = new UrukHai ("Bad guy");
            oneVersusOne.AddCharacter((IHeroes)merlin);
            oneVersusOne.AddCharacter((IEnemies)urukHai);

            oneVersusOne.DoEncounter();

            Assert.AreEqual(urukHai.Health, 0);
        }

        [Test]
        public void OneVsOneAwardsVP()
        {
            Encounters oneVersusOne = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            UrukHai urukHai = new UrukHai ("Bad guy");
            oneVersusOne.AddCharacter((IHeroes)merlin);
            oneVersusOne.AddCharacter((IEnemies)urukHai);

            oneVersusOne.DoEncounter();

            Assert.AreEqual(merlin.VictoryPoints, 2);
        }
        [Test]
        public void TwoEnemiesOneHeroFinalHeroHealth()
        {
            Encounters oneVersusOne = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            merlin.AddItem(new Staff());
            UrukHai urukHai = new UrukHai ("Bad guy");
            UrukHai urukHai1 = new UrukHai ("Bad guy 2");
            oneVersusOne.AddCharacter((IHeroes)merlin);
            oneVersusOne.AddCharacter((IEnemies)urukHai);
            oneVersusOne.AddCharacter((IEnemies)urukHai1);

            oneVersusOne.DoEncounter();

            Assert.AreEqual(merlin.Health, 60);
        }
        [Test]
        public void TwoEnemiesOneHeroEnemyDies()
        {
            Encounters oneVersusOne = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            merlin.AddItem(new Staff());
            UrukHai urukHai = new UrukHai ("Bad guy");
            UrukHai urukHai1 = new UrukHai ("Bad guy 2");
            oneVersusOne.AddCharacter((IHeroes)merlin);
            oneVersusOne.AddCharacter((IEnemies)urukHai);
            oneVersusOne.AddCharacter((IEnemies)urukHai1);

            oneVersusOne.DoEncounter();

            Assert.AreEqual(urukHai1.Health, 0);
        }
        [Test]
        public void TwoHerovsOneEnemyDies()
        {
            Encounters TwovsOne = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            merlin.AddItem(new Staff());
            UrukHai urukHai = new UrukHai ("Bad guy");
            Wizard gandalf = new Wizard ("Bad guy 2");
            TwovsOne.AddCharacter((IHeroes)merlin);
            TwovsOne.AddCharacter((IEnemies)urukHai);
            TwovsOne.AddCharacter((IHeroes)gandalf);
            TwovsOne.DoEncounter();

            Assert.AreEqual(merlin.Health, 80);
        }
         [Test]
        public void TwovsTwo()
        {
            Encounters TwovsTwo = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            merlin.AddItem(new Staff());
            UrukHai urukHai = new UrukHai ("Bad guy");
            UrukHai urukHai2 =new UrukHai ("Hurukai2");
            Wizard gandalf = new Wizard ("Gandalf2");
            TwovsTwo.AddCharacter((IHeroes)merlin);
            TwovsTwo.AddCharacter((IEnemies)urukHai);
            TwovsTwo.AddCharacter((IHeroes)gandalf);
            TwovsTwo.AddCharacter((IEnemies)urukHai2);
            TwovsTwo.DoEncounter();

            Assert.AreEqual(merlin.Health, 80);
        }
          [Test]
        public void TwovsTwoWithShield()
        {
            Encounters TwovsTwo = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            UrukHai urukHai = new UrukHai ("Bad guy");
            urukHai.AddItem(new Armor());
            urukHai.AddItem(new Armor());
            urukHai.AddItem(new Armor());
            UrukHai urukHai2 =new UrukHai ("Hurukai2");
            Wizard gandalf = new Wizard ("Gandalf2");
            TwovsTwo.AddCharacter((IHeroes)merlin);
            TwovsTwo.AddCharacter((IEnemies)urukHai);
            TwovsTwo.AddCharacter((IHeroes)gandalf);
            TwovsTwo.AddCharacter((IEnemies)urukHai2);
            TwovsTwo.DoEncounter();

            Assert.AreEqual(merlin.Health, 0);
            
        }
          [Test]
        public void TwovsTwoWithShield2()
        {
            Encounters TwovsTwo = new Encounters();
            Wizard merlin = new Wizard ("Gandalf");
            UrukHai urukHai = new UrukHai ("Bad guy");
            urukHai.AddItem(new Armor());
            urukHai.AddItem(new Armor());
            urukHai.AddItem(new Armor());
            UrukHai urukHai2 =new UrukHai ("Hurukai2");
            Wizard gandalf = new Wizard ("Gandalf2");
            TwovsTwo.AddCharacter((IHeroes)merlin);
            TwovsTwo.AddCharacter((IEnemies)urukHai);
            TwovsTwo.AddCharacter((IHeroes)gandalf);
            TwovsTwo.AddCharacter((IEnemies)urukHai2);
            TwovsTwo.DoEncounter();

            Assert.AreEqual(urukHai.Health, 0);
            
        }
    }
}