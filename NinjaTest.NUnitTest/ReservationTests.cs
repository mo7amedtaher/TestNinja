using NUnit.Framework;
using System;
using TestNinja.Fundamentals;


namespace NinjaTest.NUnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //arrange
            var Reservation = new Reservation();
            //act
            var result = Reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            //arrange
            var user = new User { IsAdmin = false };
            var Reservation = new Reservation { MadeBy = user };
            Reservation.MadeBy = user;
            //act
            var result = Reservation.CanBeCancelledBy(user);
            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherCancelling_ReturnsFalse()
        {
            //arrange
            var Reservation = new Reservation { MadeBy = new User() };
            //act
            var result = Reservation.CanBeCancelledBy(new User { IsAdmin = false });
            //assert
            Assert.That(result == false);
        }
    }
}
