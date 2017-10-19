namespace CombinedAbstractFactorySingleton.GUIElements {
    using System;

    class LightRadioButton : RadioButton
    {
        public override void Select()
        {
            Console.Out.WriteLine($"Light Radio Button [{Name}] is selected.");
        }
    }
}