using NUnit.Framework;
using System;
using RoleplayGame;

namespace Library.Test
{
    public class DwarfTest
    {
        public Dwarf petizo = new Dwarf ("El Petizo");
        public Dwarf pitufo = new Dwarf ("Enojon");

        [SetUp] public void Init()
        {
            Petizo = new Dwarf ("El Petizo");
        }

        [Test]
        public void AttackValueCorrectlyCalculated()
        {
            //Petizo comienza con un staff de poder de ataque 100
            Sword espada = new Sword();
            Petizo.AddItem(espada);
            Assert.AreEqual(Petizo.AttackValue, 120);
        }

        [Test]
        public void DefenseValueCorrectlyCalculated()
        {
            //Petizo comienza con un staff de poder de ataque 100
            Shield escudo = new Shield();
            Petizo.AddItem(escudo);
            Assert.AreEqual(Petizo.DefenseValue, 114);
        } 

        [Test]
        public void ReceiveAttackMethodWorksForAttacksHigherThanDefense()
        {
            //Petizo tiene un DefenseValue con valor 100
            Petizo.ReceiveAttack (150);
            Assert.AreEqual(Petizo.Health, 50);
        }

        [Test]
        public void CureMethodWorks()
        {
            //Petizo tiene un DefenseValue con valor 100
            Petizo.ReceiveAttack (150);
            Petizo.Cure();
            Assert.AreEqual(Petizo.Health, 100);
        }

        [Test]
        public void ReceiveAttackMethodWorksForAttacksLowerThanDefense()
        {
            //Petizo tiene un DefenseValue con valor 100
            Petizo.ReceiveAttack (50);
            //No debería bajar la vida
            Assert.AreEqual(Petizo.Health, 100);
        }

        [Test]
        public void HealthIsSetToZeroWhenKilled()
        {
            Petizo.ReceiveAttack (300);
            Assert.AreEqual(Petizo.Health, 0);
        }
    }
}