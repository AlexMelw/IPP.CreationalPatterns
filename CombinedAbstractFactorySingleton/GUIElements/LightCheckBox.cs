namespace CombinedAbstractFactorySingleton.GUIElements {
    using System;

    class LightCheckBox : CheckBox
    {
        public override void Check()
        {
            Console.Out.WriteLine($"Light Check-box [{Name}] is checked.");
        }

        public override void Uncheck()
        {
            Flag = false;
            Console.Out.WriteLine($"Dark Check-box [{Name}] is unchecked.");
        }
    }
}