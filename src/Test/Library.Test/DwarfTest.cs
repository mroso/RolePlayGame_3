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
            petizo = new Dwarf ("El Petizo");
        }

        [Test]
        public void AttackValueCorrectlyCalculated()
        {
            //Petizo comienza con un staff de poder de ataque 100
            Sword espada = new Sword();
            petizo.AddItem(espada);
            Assert.AreEqual(petizo.AttackValue, 120);
        }

        [Test]
        public void DefenseValueCorrectlyCalculated()
        {
            //Petizo comienza con un staff de poder de ataque 100
            Shield escudo = new Shield();
            petizo.AddItem(escudo);
            Assert.AreEqual(petizo.DefenseValue, 114);
        } 

        [Test]
        public void ReceiveAttackMethodWorksForAttacksHigherThanDefense()
        {
            //Petizo tiene un DefenseValue con valor 100
            petizo.ReceiveAttack (150);
            Assert.AreEqual(petizo.Health, 50);
        }

        [Test]
        public void CureMethodWorks()
        {
            //Petizo tiene un DefenseValue con valor 100
            petizo.ReceiveAttack (150);
            petizo.Cure();
            Assert.AreEqual(petizo.Health, 100);
        }

        [Test]
        public void ReceiveAttackMethodWorksForAttacksLowerThanDefense()
        {
            //Petizo tiene un DefenseValue con valor 100
            petizo.ReceiveAttack (50);
            //No debería bajar la vida
            Assert.AreEqual(petizo.Health, 100);
        }

        [Test]
        public void HealthIsSetToZeroWhenKilled()
        {
            petizo.ReceiveAttack (300);
            Assert.AreEqual(petizo.Health, 0);
        }
    }
}