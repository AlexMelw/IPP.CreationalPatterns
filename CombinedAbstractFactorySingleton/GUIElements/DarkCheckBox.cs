namespace CombinedAbstractFactorySingleton.GUIElements {
    using System;

    class DarkCheckBox : CheckBox
    {
        public override void Check()
        {
            Flag = true;
            Console.Out.WriteLine($"Dark Check-box [{Name}] is checked.");
        }

        public override void Uncheck()
        {
            Flag = false;
            Console.Out.WriteLine($"Dark Check-box [{Name}] is unchecked.");
        }
    }
}