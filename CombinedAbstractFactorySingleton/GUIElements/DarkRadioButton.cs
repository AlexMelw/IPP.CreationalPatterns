namespace CombinedAbstractFactorySingleton.GUIElements
{
    using System;

    class DarkRadioButton : RadioButton
    {
        public override void Select()
        {
            Console.Out.WriteLine($"Dark Radio Button [{Name}] is selected.");
        }
    }
}