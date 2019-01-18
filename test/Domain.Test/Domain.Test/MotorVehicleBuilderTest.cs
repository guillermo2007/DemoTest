using Domain.Builder;
using Domain.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test
{
    [TestClass]
    public class MotorVehicleBuilderTest
    {
        [TestInitialize]
        public void Configure()
        {

        }

        [TestMethod]
        public void CreateMotorVehicleBlackBuilder()
        {
            var motorVehicleBuilder = new MotorVehicleBuilder();

            var motorVehicle = motorVehicleBuilder
                                    .WithColor(Color.Black)
                                    .Build();

            Assert.AreEqual(motorVehicle.Color, Color.Black);
        }
    }
}
