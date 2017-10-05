namespace PrototypeAppliance.Example2
{
    public class Weaponry
    {
        public int Damage { get; set; }
        public int Penetration { get; set; }

        public override string ToString()
        {
            return $"{nameof(Damage)}: {Damage}, {nameof(Penetration)}: {Penetration}";
        }
    }
}