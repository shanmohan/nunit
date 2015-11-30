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

        [Test]
        public  void ShouldReturnFormattedFlightNumber_formatFlightNumber()
        {
            var sut = new Flight();

            sut.formatFlightNumber("EK", "0123");

            Assert.That("EK0123", Is.EqualTo("EK0123"));
        }

        [Test]
        public void ShouldReturnNull_WhenDefaultPropertyValueisCalled()
        {
            var sut = new Flight();
            Assert.That(sut.FlightModel, Is.Null);
        }

        [Test]
        public void ShouldFail_WhenDefaultPropertyValueisCalled()
        {
            var sut = new Flight();
            sut.FlightModel = "";
            Assert.That(sut.FlightModel, Is.Empty);
        }

        [Test]
        public void ShouldReturnTrue_WhenIsLongHaulDefaultValue()
        {
            Assert.That(new Flight().IsLongHaul, Is.False);
        }

    }
}
