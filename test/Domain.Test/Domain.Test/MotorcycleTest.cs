using System;
using System.Linq;
using AutoFixture;
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
            var motoCycle = new Motorcycle("Yamaha", (decimal)150, Color.Red, 27, 125, MotorType.Gasoline);

            Assert.AreEqual(Color.Red, motoCycle.Color);
            Assert.AreEqual(125, motoCycle.CC);
        }

        [TestMethod]
        public void CreateMotorcycleFixture()
        {
            var motoCycle = _fixture.Create<Motorcycle>();

            Assert.IsNotNull(motoCycle);
        }

        [TestMethod]
        public void CreateMotorcycleWithOutSpeedometerFixture()
        {
            var motoCycle = _fixture.Build<Motorcycle>()
                                    .Without(p => p.Speedometer)
                                    .Create();

            Assert.IsNull(motoCycle.Speedometer);
        }


        [TestMethod]
        public void CreateMotorcycleWithSameName()
        {            
            _fixture.Register<string>(() => "Motorcycle");
            var motoCycle = _fixture.Build<Motorcycle>()                                 
                                    .Create();

            Assert.AreEqual(motoCycle.Name, "Motorcycle");
        }

        [TestMethod]
        public void CreateSomeMotorcycleFixture()
        {
            var motorCycle = _fixture.CreateMany<Motorcycle>();

            Assert.IsTrue(motorCycle.Count() > 1);
        }

        [TestMethod]
        public void CreateManyMotorcyclesWithSameName()
        {
            _fixture.Register<string>(() => "Motorcycle");
            var motorCycles = _fixture.CreateMany<Motorcycle>();

            foreach (var motor in motorCycles)
            {
                Assert.AreEqual(motor.Name, "Motorcycle");
            }
        }
    }
}
