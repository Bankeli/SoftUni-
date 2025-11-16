using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeShouldLoseDurabilityAfterAttack()
        {
            // Arrange
            var axe = new Axe(20, 20);
            var dummy = new Dummy(100, 250);

            //Act

            axe.Attack(dummy);

            // Assert
            Assert.That(axe.DurabilityPoints, Is.EqualTo(19));
        }

        [Test]
        public void AxeShouldNotAttackWithoutDurability()
        {
            //Arrange
            var axe = new Axe(20, 0);
            var dummy = new Dummy(200, 20);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                axe.Attack(dummy);
            },"Axe is broken.");
        }
    }
}