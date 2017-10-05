namespace PrototypeAppliance.Example2
{
    public class Mobility
    {
        public int TopSpeed { get; set; }

        public override string ToString()
        {
            return $"{nameof(TopSpeed)}: {TopSpeed}, {nameof(Power)}: {Power}";
        }

        public int Power { get; set; }
    }
}