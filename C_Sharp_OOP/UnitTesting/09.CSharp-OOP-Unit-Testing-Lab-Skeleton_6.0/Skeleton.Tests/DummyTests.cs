using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyShouldLoseHealthIfIsHited()
        {
            //Arrange
            var axe = new Axe(20, 50);
            var dummy = new Dummy(100, 20);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.That(dummy.Health, Is.EqualTo(80));
        }

        [Test]
        public void DeadDummyShouldThrowsAnExceptionIfAttacked()
        {
            //Arrange
            var axe = new Axe(20, 80);
            var dummy = new Dummy(0, 20);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                axe.Attack(dummy);
            }, "Dummy is dead.");
        }

        [Test]
        public void DeadDummyShouldGiveXP()
        {
            //Arrange
            var dummy = new Dummy(0, 20);

            //Act
            var result = dummy.GiveExperience();

            //Assert
            Assert.That(result, Is.EqualTo(20));

        }

        [Test]
        public void AliveDummyShouldNotGiveXP()
        {
            //Arrange
            var dummy = new Dummy(30, 20);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                var result = dummy.GiveExperience();
            }, "Target is not dead.");
        }

    }
}