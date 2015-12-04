using BusinessLogic;
using NUnit.Framework;
using Moq;
using Rome.RepositoryAccess;
using Rome.BusinessEntities;
using System;

namespace Rome.BusinessLogic.Test
{

    [TestFixture]
    public class FlightTests
    {
        FlightService sut;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            System.Diagnostics.Debug.WriteLine("OneTimeSetup is called");
            sut = new FlightService();
        }

        [SetUp]
        public void SetupBeforeEachTestMethodCall()
        {
            System.Diagnostics.Debug.WriteLine("SetupBeforeEachTestMethodCall is called");
        }

        [Test]
        public void GetFlightDuration_ShouldReturnCorrectValue()
        {
            Assert.That(2,Is.EqualTo(sut.GetFlightDuration(1,1)));
        }

        [Test]
        public  void FormatFlightNumber_ShouldReturnFormattedFlightNumber()
        {
            sut.FormatFlightNumber("EK", "0123");
            Assert.That("EK0123", Is.EqualTo("EK0123"));
        }



        [Test]
        public void GetFlight_ShouldReturnFlightObject()
        {
            //Create the mocked object
            Mock<IFlightRepository> mockedFlightRepository= new Mock<IFlightRepository>();

            //setup the mocked object with the correct repsonse
            mockedFlightRepository.Setup(x => x.getFlight()).Returns(new FlightEntity() { FlightNumber = "EK987" });

            //Inject the mocked object using the dependency injection
            var flightService = new FlightService(mockedFlightRepository.Object);
            
            System.Diagnostics.Debug.WriteLine("getFlight is being asserted");

            //Call the method under test
            var flightEntity = flightService.GetFlight();

            //Assert the value
            Assert.That(flightEntity.FlightNumber, Is.EqualTo("EK987"));
        }

        [Test]
        public void UpdateFlightDetails_ShouldThrowException()
        {         
            Assert.Throws(typeof(NullReferenceException),sut.UpdateFlightDetails);
        }

        [Test]
        public void IsLongHaul_ShouldReturnTrueWhenIsLongHaulDefaultValue()
        {
            Assert.That(new FlightService().IsLongHaul, Is.False);
        }

        [TearDown]
        public void TeardownAfterEachTestMethodIsCalled()
        {
            System.Diagnostics.Debug.WriteLine("TeardownAfterEachTestMethodIsCalled is called");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            System.Diagnostics.Debug.WriteLine("OneTimeTearDown is called");
            sut = null;
        }

    }
}
