using BusinessLogic;
using NUnit.Framework;

namespace Rome.BusinessLogic.Test
{

    [TestFixture]
    public class FlightTests
    {
        [Test]
        public void TestgetFlightDuration()
        {
            var sut = new Flight();
            Assert.That(2,Is.EqualTo(sut.getFlightDuration(1,1)));
        }

    }
}
