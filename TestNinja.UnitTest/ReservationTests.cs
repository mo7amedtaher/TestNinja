using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //arrange
            var Reservation = new Reservation();
            //act
            var result =Reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            //arrange
            var user = new User { IsAdmin = false };
            var Reservation = new Reservation { MadeBy = user };
            Reservation.MadeBy = user;
            //act
            var result = Reservation.CanBeCancelledBy(user);
            //assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherCancelling_ReturnsFalse()
        {
            //arrange
            var Reservation = new Reservation{MadeBy = new User() };
            //act
            var result = Reservation.CanBeCancelledBy(new User { IsAdmin = false });
            //assert
            Assert.AreEqual(result, false);
        }
    }
}
