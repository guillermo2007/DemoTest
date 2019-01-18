using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Builder
{
    public class MotorVehicleBuilder
    {
        private string _name;
        private decimal _weigth;
        public int _wheels;
        public int _cv;
        public int _cc;
        private Color _color;
        public MotorType _motorType;

        public MotorVehicleBuilder()
        {
            
        }

        public MotorVehicleBuilder WithName(string name)
        {
            this._name = name;
            return this;
        }

        public MotorVehicleBuilder WithColor(Color color)
        {
            this._color = color;
            return this;
        }

        public MotorVehicleBuilder WithWeight(decimal weight)
        {
            this._weigth = weight;
            return this;
        }

        public MotorVehicleBuilder WithCv(int cv)
        {
            this._cv = cv;
            return this;
        }

        public MotorVehicleBuilder WithCC(int cc)
        {
            this._cc = cc;
            return this;
        }

        public MotorVehicleBuilder WithMotorType(MotorType type)
        {
            this._motorType = type;
            return this;
        }

        public MotorVehicleBuilder WithWheels(int wheels)
        {
            this._wheels = wheels;
            return this;
        }

        public MotorVehicle Build()
        {
            return new MotorVehicle(_name, _wheels, _weigth, _color, _cv, _cc, _motorType);
        }

    }
}
