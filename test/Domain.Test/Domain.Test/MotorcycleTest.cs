using System;
using System.Linq;
using AutoFixture;
using AutoFixture.Kernel;
using Domain.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Test
{
    [TestClass]
    public class MotorcycleTest
    {
        private Fixture _fixture;

        [TestInitialize]
        public void Configure()
        {
            _fixture = new Fixture();
        }

        [TestMethod]
        public void CreateMotorcycle125ccRed()
        {
            var motoCycle = new Motocycle("Yamaha", (decimal)150, Color.Red, 27, 125, MotorType.Gasoline);

            Assert.AreEqual(Color.Red, motoCycle.Color);
            Assert.AreEqual(125, motoCycle.CC);
        }

        [TestMethod]
        public void CreateMotorcycleFixture()
        {
            var motoCycle = _fixture.Create<Motocycle>();

            Assert.IsNotNull(motoCycle);
        }

        [TestMethod]
        public void CreateMotorcycleWithOutSpeedometerFixture()
        {
            var motoCycle = _fixture.Build<Motocycle>()                                       
                                    .Without(p => p.Speedometer)
                                    .Create();

            Assert.IsNull(motoCycle.Speedometer);
        }


        [TestMethod]
        public void CreateMotorcycleWithSameName()
        {
            _fixture.Register<string>(() => "Motorcycle");
            var motoCycle = _fixture.Build<Motocycle>()
                                    .Create();

            Assert.AreEqual(motoCycle.Name, "Motorcycle");
        }

        [TestMethod]
        public void CreateSomeMotorcycleFixture()
        {
            var motorCycle = _fixture.CreateMany<Motocycle>();

            Assert.IsTrue(motorCycle.Count() > 1);
        }

        [TestMethod]
        public void CreateManyMotorcyclesWithSameName()
        {
            _fixture.Register<string>(() => "Motorcycle");
            var motorCycles = _fixture.CreateMany<Motocycle>();

            foreach (var motor in motorCycles)
            {
                Assert.AreEqual(motor.Name, "Motorcycle");
            }
        }

        [TestMethod]
        public void CreateAnyVehicle()
        {
            _fixture.Customizations.Add(
                                    new TypeRelay(
                                        typeof(Vehicle),
                                        typeof(Motocycle)));

            var vehicle = _fixture.Create<Vehicle>();

            Assert.IsTrue(vehicle is Motocycle);

        }
    }
}
