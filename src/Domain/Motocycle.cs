using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Motocycle : MotorVehicle
    {
        public Motocycle(string name, decimal weight, Color color, int cv, int cc, MotorType motorType) : base(name, 2, weight, color, cv, cc, motorType)
        {

        }
    }
}
