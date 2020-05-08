using NUnit.Framework;
using System;
using RoleplayGame;

namespace Library.Test
{

/*
Test para Esqueleto
*/
    public class TestEsqueleto
    {
        public Esqueletos huesudo = new Esqueletos ("Purohueso");
        public Esqueletos demon= new Esqueletos ("Demon");

        [SetUp] public void Init()
        {
            huesudo = new Esqueletos ("Purohueso");
        }

        [Test]
        public void AttackValueCorrectlyCalculated()
        {
            //Purohueso comienza con un staff de poder de ataque 100 y las hachas tienen 25 de ataque
            Axe filosa = new Axe();
            huesudo.AddItem(filosa);
            Assert.AreEqual(huesudo.AttackValue, 125);
        }

        [Test]
        public void DefenseValueCorrectlyCalculated()
        {
            //Purohueso comienza con un staff de poder de ataque 100 y las armaduras tienen una defensa de 25
            Armor deHierro = new Armor();
            huesudo.AddItem(deHierro);
            Assert.AreEqual(huesudo.DefenseValue, 125);
        } 

        [Test]
        public void ReceiveAttackMethodWorksForAttacksHigherThanDefense()
        {
            //Purohueso tiene un DefenseValue con valor 100
            huesudo.ReceiveAttack (150);
            Assert.AreEqual(huesudo.Health, 50);
        }

        [Test]
        public void CureMethodWorks()
        {
            //Purohueso tiene un DefenseValue con valor 100
            huesudo.ReceiveAttack (150);
            huesudo.Cure();
            Assert.AreEqual(huesudo.Health, 100);
        }

        [Test]
        public void ReceiveAttackMethodWorksForAttacksLowerThanDefense()
        {
            //huesudo tiene un DefenseValue con valor 100
            huesudo.ReceiveAttack (10);
            //No debería bajar la vida
            Assert.AreEqual(huesudo.Health, 100);
        }

        [Test]
        public void HealthIsSetToZeroWhenKilled()
        {
            huesudo.ReceiveAttack (100);
            Assert.AreEqual(huesudo.Health, 0);
        }
    }
}