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
            mineris = new Troll ("Mineris");
        }

        [Test]
        public void AttackValueCorrectlyCalculated()
        {
            //Mineris comienza con un staff de poder de ataque 100
            Sword espada = new Sword();
            mineris.AddItem(espada);
            Assert.AreEqual(mineris.AttackValue, 120);
        }

        [Test]
        public void DefenseValueCorrectlyCalculated()
        {
            //Mineris comienza con un staff de poder de ataque 100
            Shield escudo = new Shield();
            mineris.AddItem(escudo);
            Assert.AreEqual(mineris.DefenseValue, 114);
        } 

        [Test]
        public void ReceiveAttackMethodWorksForAttacksHigherThanDefense()
        {
            //Mineris tiene un DefenseValue con valor 100
            mineris.ReceiveAttack (150);
            Assert.AreEqual(mineris.Health, 50);
        }

        [Test]
        public void CureMethodWorks()
        {
            //Mineris tiene un DefenseValue con valor 100
            mineris.ReceiveAttack (150);
            mineris.Cure();
            Assert.AreEqual(mineris.Health, 100);
        }

        [Test]
        public void ReceiveAttackMethodWorksForAttacksLowerThanDefense()
        {
            //Mineris tiene un DefenseValue con valor 100
            mineris.ReceiveAttack (50);
            //No debería bajar la vida
            Assert.AreEqual(mineris.Health, 100);
        }

        [Test]
        public void HealthIsSetToZeroWhenKilled()
        {
            mineris.ReceiveAttack (300);
            Assert.AreEqual(mineris.Health, 0);
        }
    }
}