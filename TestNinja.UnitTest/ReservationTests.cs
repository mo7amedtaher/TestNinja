using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange
            var Reservation = new Reservation();
            //act
            var result =Reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CanBeCancelledBy_CreatedByUser_ReturnsTrue()
        {
            //arrange
            var Reservation = new Reservation();
            var user = new User { IsAdmin = false };
            Reservation.MadeBy = user;
            //act
            var result = Reservation.CanBeCancelledBy(user);
            //assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserNotAdminNorTheCreator_ReturnsFalse()
        {
            //arrange
            var Reservation = new Reservation();
            //act
            var result = Reservation.CanBeCancelledBy(new User { IsAdmin = false });
            //assert
            Assert.AreEqual(result, false);
        }
    }
}
