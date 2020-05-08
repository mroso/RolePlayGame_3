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

            Assert.AreEqual(merlin.VictoryPoints, 1);
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
    }
}