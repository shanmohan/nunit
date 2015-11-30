using NUnit.Framework;
using BusinessLogic;

namespace Rome.BusinessLogic.Test
{
    [TestFixture]
    public class FlightOptionTests
    {

        [Test]
        public void FlightAmenitiesShouldNotHaveAnyEmptyValues()
        {
            var sut = new FlightOption();

            Assert.That(sut.Amenities, Is.All.Not.Empty);

        }

    }
}
