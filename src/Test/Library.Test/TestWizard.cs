using NUnit.Framework;
using System;
using RoleplayGame;

namespace Library.Test
{
    public class TestWizard
    {
        public Wizard merlin = new Wizard ("Merlin");
        public Wizard peverell = new Wizard ("Peverell");

        [SetUp] public void Init()
        {
            merlin = new Wizard ("Merlin");
        }

        [Test]
        public void AttackValueCorrectlyCalculated()
        {
            //Merlin comienza con un staff de poder de ataque 100
            Sword espada = new Sword();
            merlin.AddItem(espada);
            Assert.AreEqual(merlin.AttackValue, 120);
        }

        [Test]
        public void DefenseValueCorrectlyCalculated()
        {
            //Merlin comienza con un staff de poder de ataque 100
            Shield escudo = new Shield();
            merlin.AddItem(escudo);
            Assert.AreEqual(merlin.DefenseValue, 114);
        } 

        [Test]
        public void ReceiveAttackMethodWorksForAttacksHigherThanDefense()
        {
            //Merlin tiene un DefenseValue con valor 100
            merlin.ReceiveAttack (150);
            Assert.AreEqual(merlin.Health, 50);
        }

        [Test]
        public void CureMethodWorks()
        {
            //Merlin tiene un DefenseValue con valor 100
            merlin.ReceiveAttack (150);
            merlin.Cure();
            Assert.AreEqual(merlin.Health, 100);
        }

        [Test]
        public void ReceiveAttackMethodWorksForAttacksLowerThanDefense()
        {
            //Merlin tiene un DefenseValue con valor 100
            merlin.ReceiveAttack (50);
            //No debería bajar la vida
            Assert.AreEqual(merlin.Health, 100);
        }

        [Test]
        public void HealthIsSetToZeroWhenKilled()
        {
            merlin.ReceiveAttack (300);
            Assert.AreEqual(merlin.Health, 0);
        }
    }
}