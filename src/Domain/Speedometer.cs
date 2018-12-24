namespace Domain
{
    public class Speedometer
    {
        public Speedometer()
        {
            Velocity = 0;
            Kilometers = 0;
            Limit = null;
        }
        
        public int Velocity { get; set; }
        public static int Kilometers { get; set; }
        public int? Limit { get; set; }
        public int? Regulator { get; set; }

        public void UpVelocity()
        {
            if (Limit.HasValue && Limit.Value > Velocity)
                throw new System.Exception("Limit is on and it isnt increasing");
            Velocity++;
        }

        public void DownVelocity()
        {
            Velocity--;
        }

        public bool IsRegulatorOn()
        {
            return Regulator.HasValue;   
        }

        public bool IsLimitOn()
        {
            return Limit.HasValue;
        }

    }
}
