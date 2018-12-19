namespace Domain
{
    public class Speedometer
    {
        public Speedometer()
        {

        }
        
        public int Velocity { get; set; }
        public int Kilometers { get; set; }
        public int? Limit { get; set; }
        public int Regulator { get; set; }

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

    }
}
