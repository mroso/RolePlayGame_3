using NUnit.Framework;
using System;
using RoleplayGame;

namespace Library.Test
{

/*
Test para Orcos
*/
    public class Orcos
    {
        public Orcos devil = new Orcos ("Devil");
        public Orcos demon = new Orcos ("Demon");

        [SetUp] public void Init()
        {
            devil = new Orcos ("Devil");
        }

        [Test]
        public void AttackValueCorrectlyCalculated()
        {
            //Devil comienza con un staff de poder de ataque 100 y las hachas tienen 25 de ataque
            Axe filosa = new Axe();
            devil.AddItem(filosa);
            Assert.AreEqual(devil.AttackValue, 125);
        }

        [Test]
        public void DefenseValueCorrectlyCalculated()
        {
            //Devil comienza con un staff de poder de ataque 100 y las armaduras tienen una defensa de 25
            Armor deHierro = new Armor();
            devil.AddItem(deHierro);
            Assert.AreEqual(devil.DefenseValue, 125);
        } 

        [Test]
        public void ReceiveAttackMethodWorksForAttacksHigherThanDefense()
        {
            //Devil tiene un DefenseValue con valor 100
            devil.ReceiveAttack (150);
            Assert.AreEqual(devil.Health, 50);
        }

        [Test]
        public void CureMethodWorks()
        {
            //Devil tiene un DefenseValue con valor 100
            devil.ReceiveAttack (150);
            devil.Cure();
            Assert.AreEqual(devil.Health, 100);
        }

        [Test]
        public void ReceiveAttackMethodWorksForAttacksLowerThanDefense()
        {
            //Devil tiene un DefenseValue con valor 100
            devil.ReceiveAttack (10);
            //No debería bajar la vida
            Assert.AreEqual(devil.Health, 100);
        }

        [Test]
        public void HealthIsSetToZeroWhenKilled()
        {
            devil.ReceiveAttack (100);
            Assert.AreEqual(devil.Health, 0);
        }
    }
}