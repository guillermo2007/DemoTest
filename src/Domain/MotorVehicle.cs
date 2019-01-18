using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MotorVehicle : Vehicle
    {
        public MotorVehicle(string name, int wheels, decimal weight, Color color, int cv, int cc, MotorType motorType) : base(name, wheels,weight,color)
        {
            Cv = cv;
            CC = cc;
            MotorType = motorType;
        }

        public int Cv { get; set; }
        public int CC { get; set; }
        public MotorType MotorType { get; set; }
        public Speedometer Speedometer { get; set; }
    }
}
