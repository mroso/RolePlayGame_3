using NUnit.Framework;
using System;
using RoleplayGame;

namespace Library.Test
{
    public class TestTroll
    {
        public Troll mineris = new Troll ("Mineris");

        [SetUp] public void Init()
        {
            Mineris = new Troll ("Mineris");
        }

        [Test]
        public void AttackValueCorrectlyCalculated()
        {
            //Mineris comienza con un staff de poder de ataque 100
            Sword espada = new Sword();
            Mineris.AddItem(espada);
            Assert.AreEqual(Mineris.AttackValue, 120);
        }

        [Test]
        public void DefenseValueCorrectlyCalculated()
        {
            //Mineris comienza con un staff de poder de ataque 100
            Shield escudo = new Shield();
            Mineris.AddItem(escudo);
            Assert.AreEqual(Mineris.DefenseValue, 114);
        } 

        [Test]
        public void ReceiveAttackMethodWorksForAttacksHigherThanDefense()
        {
            //Mineris tiene un DefenseValue con valor 100
            Mineris.ReceiveAttack (150);
            Assert.AreEqual(Mineris.Health, 50);
        }

        [Test]
        public void CureMethodWorks()
        {
            //Mineris tiene un DefenseValue con valor 100
            Mineris.ReceiveAttack (150);
            Mineris.Cure();
            Assert.AreEqual(Mineris.Health, 100);
        }

        [Test]
        public void ReceiveAttackMethodWorksForAttacksLowerThanDefense()
        {
            //Mineris tiene un DefenseValue con valor 100
            Mineris.ReceiveAttack (50);
            //No debería bajar la vida
            Assert.AreEqual(Mineris.Health, 100);
        }

        [Test]
        public void HealthIsSetToZeroWhenKilled()
        {
            Mineris.ReceiveAttack (300);
            Assert.AreEqual(Mineris.Health, 0);
        }
    }
}