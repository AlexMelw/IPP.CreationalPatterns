namespace PrototypeAppliance.Example2
{
    using System;
    using System.Collections.Generic;
    using EasySharp.NHelpers.CustomExMethods;
    using NClone;
    using NClone.MetadataProviders;

    public class Tank
    {
        [CustomReplicationBehavior(ReplicationBehavior.DeepCopy)]
        public Weaponry Weaponry { get; set; }

        [CustomReplicationBehavior(ReplicationBehavior.Copy)]
        public Mobility Mobility { get; set; }

        [CustomReplicationBehavior(ReplicationBehavior.Ignore)]
        public IList<CrewType> Crew { get; set; }

        public Tank Replicate()
        {
            return Clone.ObjectGraph(this);
        }


        public override string ToString()
        {
            string newLine = Environment.NewLine;

            return $"{nameof(Weaponry)}: {{ {Weaponry} }}, " + newLine +
                   $"{nameof(Mobility)}: {{ {Mobility} }}, " + newLine +
                   $"{nameof(Crew)}: {Crew.ToCommaSeparatedStringWithEndingDot()}" + newLine;
        }
    }
}